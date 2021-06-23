using Library.App.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.Service
{
    public interface IBook
    {
        List<Book> GetBooks();
        List<Book> GetBookByTitle(string title);
        List<Book> GetBookById(int id);

        List<Book> GetBookByAuthor(string author);

        bool AddBook(Book book);

        bool DeleteBook(int id);

        bool UpdateBook(Book book);
        

    }
}
