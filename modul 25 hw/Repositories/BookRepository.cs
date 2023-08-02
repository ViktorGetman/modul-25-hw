using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_25_hw.Repositories
{
    public class BookRepository
    {
        public Book GetById(int objectId)
        {
            using (var context = new AppContext()) // замените "YourDbContext" на имя вашего контекста базы данных
            {
                var obj = context.Books.FirstOrDefault(x => x.Id == objectId); // замените "YourObjects" на имя вашей таблицы в БД
                return obj;
            }
        }
        public IEnumerable<Book> Get()
        {
            using (var context = new AppContext()) // замените "YourDbContext" на имя вашего контекста базы данных
            {
                return context.Books.ToList();
            }
        }
        public void Add(Book book)
        {
            using (var context = new AppContext()) // замените "YourDbContext" на имя вашего контекста базы данных
            {
               context.Books.Add(book);
                context.SaveChanges();
            }
        }
        public void Delete(Book book)
        {
            using (var context = new AppContext()) // замените "YourDbContext" на имя вашего контекста базы данных
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }
        public void UpdateYearIssue(int id, string yearIssue)
        {
            using (var context = new AppContext()) // замените "YourDbContext" на имя вашего контекста базы данных
            {
                var obj = context.Books.First(x => x.Id == id);
                obj.YearIssue = yearIssue;
                context.Update(obj);
                context.SaveChanges();
            }
        }

    }
}
