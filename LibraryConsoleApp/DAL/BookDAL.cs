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
        public List<Book> GetBookByTitle(string title)
        {
            List<Book> resultList = new List<Book>();
            foreach(Book book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    resultList.Add(book);
            }
            return resultList;
           
           
        }

        // Get book by Id
        public List<Book> GetBookById(int id)
        {
            List<Book> resultList = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Id == id)
                    resultList.Add(book);
            }
            return resultList;
        }

        public List<Book> GetBookByAuthor(string author)
        {
            List<Book> resultList = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                    resultList.Add(book);
            }
            return resultList;
        }

        public bool AddBook(Book book)
        {
            bool isSuccess = false;
            try
            {
                Book newBook = new Book()
                {
                    Id = book.Id,
                    Title = book.Title,
                    ISBN = book.ISBN,
                    Author = book.Author,
                    Language = book.Language,
                    Subject = book.Subject,
                    Publisher = book.Publisher
                    
                };
                books.Add(newBook);
                isSuccess = true;
            }
            catch (FormatException)
            {
                isSuccess = false;
            }
            return isSuccess;
        }

        public bool DeleteBook(int id)
        {
            bool isSuccess = false;
            try
            {
                Book deleteBook = books.Find(s => s.Id == id);
                books.Remove(deleteBook);
            }
            catch (FormatException)
            {
                isSuccess = false;

            }
            return isSuccess;
        }

        public bool UpdateBook(Book book)
        {
            bool isSuccess = false;
            try
            {
                Book updateBook = books.Find(b => b.Id == book.Id);


                updateBook.Title = book.Title;
                updateBook.ISBN = book.ISBN;
                updateBook.Author = book.Author;
                updateBook.Language = book.Language;
                updateBook.Subject = book.Subject;
                updateBook.Publisher = book.Publisher;
            }
            catch (FormatException)
            {
                isSuccess = false;
            }
            return isSuccess;
        }
    }

}
