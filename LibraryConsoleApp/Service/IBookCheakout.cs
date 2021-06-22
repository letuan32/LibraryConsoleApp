using Library.App.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.Service
{
    public interface IBookCheckout
    {
        List<BookCheckout> GetAll();

        List<BookCheckout> GetByIBookTitle(string title);

        BookCheckout GetById(int id);

        bool Add(int id, string bookTitle, DateTime borrowDate, DateTime dueDate);

        bool UpdateById(int id, string bookTitle, DateTime borrowDate, DateTime dueDate, bool isReturn);

    }
}
