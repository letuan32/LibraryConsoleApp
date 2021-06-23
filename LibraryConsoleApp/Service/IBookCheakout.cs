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

        bool Add(BookCheckout bookCheckout);

        bool UpdateById(int recordId,int menberId, string bookTitle, bool isReturn);
        bool DeleteById(int recordId);
    }
}
