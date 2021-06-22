using Library.App.Entities;
using Library.App.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.App.DAL
{
    public class BookCheckoutDAL:IBookCheckout
    {
        private static List<BookCheckout> bookCheckouts = new List<BookCheckout>()
        {
            new BookCheckout()
            {
                RecordId = 1,
                BookTitle = "Introduction to C#",
                BorrowDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(15),
                IsReturn = false
            }
        };

        public List<BookCheckout> GetAll()
        {
            return bookCheckouts;
        }

        public List<BookCheckout> GetByIBookTitle(string title)
        {
            List<BookCheckout> checkouts = new List<BookCheckout>();
            foreach(BookCheckout _checkout in bookCheckouts)
            {
                if(_checkout.BookTitle.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    checkouts.Add(_checkout);
                }                 
            }
            return checkouts;
        }

        public BookCheckout GetById(int id)
        {
            var checkout = bookCheckouts.FirstOrDefault(c=>c.RecordId == id);
            return checkout;
        }

        public bool Add(int id, string bookTitle, DateTime borrowDate, DateTime dueDate)
        {
            bool status = false;
            try
            {
                BookCheckout newRecord = new BookCheckout()
                {
                    RecordId = id,
                    BookTitle = bookTitle,
                    BorrowDate = borrowDate,
                    DueDate = dueDate
                };
                bookCheckouts.Add(newRecord);
                status = true;
            }
            catch(FormatException)
            {
                status = false;
            }
            return status;
            
        }

        public bool UpdateById(int id, string bookTitle, bool isReturn)
        {
            bool status = false;
            try
            {
                BookCheckout updateRecord = bookCheckouts.Find(b => b.RecordId == id);

                updateRecord.BookTitle = bookTitle;
                updateRecord.IsReturn = isReturn;
                status = true;
            }
           catch(FormatException)
            {
                status = false;
            }
            return status;

        }
        
    }
}
