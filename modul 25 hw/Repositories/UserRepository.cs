using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_25_hw.Repositories
{
    internal class UserRepository
    {
        public User GetById(int objectId)
        {
            using (var context = new AppContext()) // замените "YourDbContext" на имя вашего контекста базы данных
            {
                var obj = context.Users.FirstOrDefault(x => x.Id == objectId); // замените "YourObjects" на имя вашей таблицы в БД
                return obj;
            }
        }
        public IEnumerable<User> Get()
        {
            using (var context = new AppContext()) // замените "YourDbContext" на имя вашего контекста базы данных
            {
                return context.Users.ToList();
            }
        }
        public void Add(User user)
        {
            using (var context = new AppContext()) // замените "YourDbContext" на имя вашего контекста базы данных
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        public void Delete(User user)
        {
            using (var context = new AppContext()) // замените "YourDbContext" на имя вашего контекста базы данных
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }
        public void UpdateName(int id, string name)
        {
            using (var context = new AppContext()) // замените "YourDbContext" на имя вашего контекста базы данных
            {
                var obj = context.Users.First(x => x.Id == id);
                obj.Name = name;
                context.Update(obj);
                context.SaveChanges();
            }
        }

    }
}
