using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Online_E.Models
{
    public class BooksDbInitialize : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name ="Война и мир" , Author = "Л.Толстой", Price = 220});
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И.Тургенев", Price = 480});
            db.Books.Add(new Book { Name = "Чайка", Author = "А.Чехов", Price = 150});

            base.Seed(db);
        }
    }
}