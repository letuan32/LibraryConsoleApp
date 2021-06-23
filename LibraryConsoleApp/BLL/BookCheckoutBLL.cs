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

        public List<BookCheckout> GetByIBookTitle(string title)
        {
            return _bookCheckout.GetByIBookTitle(title);
        }

        public BookCheckout GetById(int id)
        {
            return _bookCheckout.GetById(id);
        }

        public bool Add(BookCheckout bookCheckout)
        {
            return _bookCheckout.Add(bookCheckout);
        }
        public bool DeleteById(int recordId)
        {
            return _bookCheckout.DeleteById(recordId);
        }

        public bool UpdateById(int recordId, int memberId, string bookTitle, bool isReturn)
        {
            return _bookCheckout.UpdateById( recordId, memberId, bookTitle, isReturn);
        }
    }
}
