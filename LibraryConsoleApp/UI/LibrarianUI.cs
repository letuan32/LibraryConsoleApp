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

        private void LibrarianMenu()
        {
            bool loop = true;
            while (loop == true)
            {
                try
                {
                    // Menu
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t-----------Librarian Menu-------------");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("1) Book management\n" +
                    "2) Book checkout management \n" +
                    "3) Member Management\n" +
                    "4) Logout\n"
                    ) ;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    // End Menu

                    //Get Choice
                    Console.ForegroundColor = ConsoleColor.White;
               
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            BookUI bookUI = new BookUI();
                            bookUI.BookMenu();
                            break;
                        case 2:
                            BookCheckoutUI bookCheckoutUI = new BookCheckoutUI();
                            bookCheckoutUI.BooKCheckoutMenu();
                            break;
                        case 3:
                            MemberUI menberUI = new MemberUI();
                            menberUI.MemberManagementMenu();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Logged out successfully..\nTada have a nice day...");
                            Console.ForegroundColor = ConsoleColor.White;
                            loop = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input!!!");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                       
                            
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry try agian once!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            }
            //End Get Choice
        }




    }
}
