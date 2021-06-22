using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.Entities
{
    public class BookCheckout
    {
        public int RecordId { get; set; }
        public string BookTitle { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsReturn { get; set; }

    }
}
