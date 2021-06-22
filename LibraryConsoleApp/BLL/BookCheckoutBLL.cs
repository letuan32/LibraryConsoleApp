using Library.App.Entities;
using Library.App.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.BLL
{
    public class BookCheckoutBLL
    {
        public IBookCheckout _bookCheckout;
        public BookCheckoutBLL(IBookCheckout bookCheckout)
        {
            _bookCheckout = bookCheckout;
        }

        // Method check valid input

        public List<BookCheckout> GetAll()
        {

            return _bookCheckout.GetAll();
        }

        List<BookCheckout> GetByIBookTitle(string title)
        {
            return _bookCheckout.GetByIBookTitle(title);
        }

        BookCheckout GetById(int id)
        {
            return _bookCheckout.GetById(id);
        }

        bool Add(int id, string bookTitle, DateTime borrowDate, DateTime dueDate)
        {
            return _bookCheckout.Add(id, bookTitle, borrowDate, dueDate);
        }

        bool UpdateById(int id, string bookTitle, bool isReturn)
        {
            return _bookCheckout.UpdateById(id, bookTitle, isReturn);
        }
    }
}
