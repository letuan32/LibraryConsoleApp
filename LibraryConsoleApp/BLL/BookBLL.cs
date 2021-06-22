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
        
        public Book GetBookById(int id)
        {
            return _bookDAL.GetBookById(id);
        }
        public Book GetBookByTitle(string title)
        {
            return _bookDAL.GetBookByTitle(title);
        }

        public List<Book> GetBooks()
        {
            return _bookDAL.GetBooks();
            
        }
    }
}
