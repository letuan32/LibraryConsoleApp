using Library.App.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.BLL
{
    public class LibrarianBLL
    {
        public ILibrarian _librarianDAL;
        public LibrarianBLL(ILibrarian librarianDAL )
        {
            _librarianDAL = librarianDAL;
        }

        // Login
        public bool Login(string username, string password)
        {
            bool isSuccess = false;
            isSuccess = _librarianDAL.Login(username, password);
            if (isSuccess == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in successfully...");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Invalid Username Id or Password...");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
    }
}
