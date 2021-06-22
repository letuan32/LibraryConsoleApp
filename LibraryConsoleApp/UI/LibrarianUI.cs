using Library.App.BLL;
using Library.App.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.UI
{
    public class LibrarianUI
    {
        public void LibrarianLogin()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Admin-Login-----------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                LibrarianBLL librarianBLL = new LibrarianBLL(new LibrarianDAL());
                bool isSuccess = librarianBLL.Login(username, password);
                if (isSuccess == true)
                {
                    LibrarianMenu();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            catch (FormatException)
            {
                
            }

        }

        public void LibrarianMenu()
        {

        }
        public void MemberManagement()
        {

        }

        public void BookSection()
        {

        }



    }
}
