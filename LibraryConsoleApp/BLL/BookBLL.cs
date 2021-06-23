using Library.App.Entities;
using Library.App.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.BLL
{
    public class BookBLL
    {
        public IBook _bookDAL;
        public BookBLL(IBook bookDAL)
        {
            this._bookDAL = bookDAL;
        }

        public List<Book> GetBookById(int id)
        {
            return _bookDAL.GetBookById(id);
        }
        public List<Book> GetBookByTitle(string title)
        {
            return _bookDAL.GetBookByTitle(title);
        }
        public List<Book> GetBookByAuthor(string author)
        {
            return _bookDAL.GetBookByAuthor(author);
        }

        public List<Book> GetBooks()
        {
            return _bookDAL.GetBooks();

        }

        public bool AddBook(Book book)
        {

            return _bookDAL.AddBook(book);
        }
        public bool DeleteBook(int id)
        {
            return _bookDAL.DeleteBook(id);
        }
        public bool UpdateBook(Book book)
        {
            return _bookDAL.UpdateBook(book);
        }
    }
}
