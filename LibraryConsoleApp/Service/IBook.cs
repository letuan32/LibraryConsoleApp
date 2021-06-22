using Library.App.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.Service
{
    public interface IBook
    {
        List<Book> GetBooks();
        Book GetBookByTitle(string title);
        Book GetBookById(int id);

        List<Book> GetByAuthor();

    }
}
