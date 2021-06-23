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
                MemberId = 1,
                BookTitle = "Introduction to C#",
                BorrowDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(15),
                IsReturn = false
            },
            new BookCheckout()
            {
                RecordId = 2,
                MemberId = 2,
                BookTitle = "Basic Python",
                BorrowDate = DateTime.Now.AddDays(-20),
                DueDate = DateTime.Now.AddDays(-10),
                IsReturn = true
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

        public bool Add(BookCheckout record)
        {
            bool status = false;
            try
            {
                BookCheckout newRecord = new BookCheckout()
                {
                    RecordId = record.RecordId,
                    MemberId = record.MemberId,
                    BookTitle = record.BookTitle,
                    BorrowDate =record.BorrowDate,
                    DueDate = record.DueDate,
                 
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

        public bool UpdateById(int recordId, int menberId, string bookTitle, bool isReturn)
        {
            bool status = false;
            try
            {
                BookCheckout updateRecord = bookCheckouts.Find(b => b.RecordId == recordId);

                updateRecord.MemberId = menberId;
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

        public bool DeleteById(int recordId)
        {
            bool isSuccess = false;
            try
            {
                BookCheckout deleteRecord = bookCheckouts.Find(s => s.RecordId == recordId);
                bookCheckouts.Remove(deleteRecord);
            }
            catch (FormatException)
            {
                isSuccess = false;

            }
            return isSuccess;
        }
    }
}
