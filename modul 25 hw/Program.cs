using Microsoft.EntityFrameworkCore;
using modul_25_hw.Repositories;
using static System.Reflection.Metadata.BlobBuilder;


namespace modul_25_hw;
public class Program
{
    static void Main(string[] args)
    {
        /*using (var db = new AppContext())
        {
            var user1 = new User { Name = "Arthur", Email = "Arthur@mail.ru"};
            var user2 = new User { Name = "klim", Email = "klim@mail.ru"};
            var book1 = new Book { Name = "kolobok", YearIssue = "2002" };
            var book2 = new Book { Name = "pinokio", YearIssue = "2003" };

            db.Users.Add(user1);
            db.Users.Add(user2);
            db.Books.Add(book1);
            db.Books.Add(book2);

            db.SaveChanges();
        }*/

        ///var Repository = new BookRepository();

        //var Books = Repository.GetById(3);
        ///Repository.Add(new Book { Name = "pinokio2", YearIssue = "2003" });
        ///Repository.UpdateYearIssue(3, "999");
        //Repository.Delete(Books); 

        var Repository = new UserRepository();
        //var Users = Repository.GetById(2);
        ///var Users = Repository.Get;
        ///Repository.Add(new User { Name = "klimon", Email = "klimon@mail.ru" });
       var Users = Repository.GetById(3);
        ///Repository.UpdateName(3, "viktor");
        Repository.Delete(Users);

    }
}