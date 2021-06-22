using Library.App.Entities;
using Library.App.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.App.DAL
{
    public class BookDAL:IBook
    {
        private static List<Book> books = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Introduction to C#",
                Author = "Unknow",
                ISBN = "123321",
                Publisher = "Unknow",
                Language = "English",
                Subject = "IT"
            },
            new Book()
            {
                Id = 2,
                Title = "Basic Pyhon",
                Author = "Unknow",
                ISBN = "72349",
                Publisher = "Unknow",
                Language = "English",
                Subject = "IT"
            },
        };

        // Get all book
        public List<Book> GetBooks()
        {
            return books;
        }

        //Get book by title
        public Book GetBookByTitle(string title)
        {
            var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            return book;
        }

        // Get book by Id
        public Book GetBookById(int id)
        {
            var book = books.FirstOrDefault(b=>b.Id == id );
            return book;
        }

        public List<Book> GetByAuthor()
        {
            throw new NotImplementedException();
        }
    }

}
