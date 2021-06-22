using Library.App.Entities;
using Library.App.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.DAL
{
    public class LibrarianDAL:ILibrarian
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

        public bool Login(string username, string password)
        {
            bool isSuccess = false;
            if (librarians.Exists(u => u.Username == username && u.Password == password))
                isSuccess = true;
            else
                isSuccess = false;
            return isSuccess;
        }
    }
}
