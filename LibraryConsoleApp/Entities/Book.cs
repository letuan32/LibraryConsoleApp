using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public string Subject { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
       
    }
}
