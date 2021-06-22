using Library.App.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.DAL
{
    public class LibrarianDAL
    {
        private static List<Librarian> librarians = new List<Librarian>()
        {
            new Librarian()
            {
                Id = 1, Username = "admin", Password = "12345"
            },
        };
        public List<Librarian> GetAllAdminsDAL()
        {
            return librarians ;
        }
    }
}
