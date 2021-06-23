using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.UI
{
    public class StartUI
    {
        public void StartMenu()
        {
            bool loop = true;
            while (loop==true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Library Management System");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1) Press 1 to login as Librarian\n" +
                    "2) Press 2 to login as Staff\n" +
                    "3) Press 3 to exit");

                    int roleChoice = int.Parse(Console.ReadLine());
                    switch (roleChoice)
                    {
                        case 1:
                            LibrarianUI librarianUI = new LibrarianUI();
                            librarianUI.LibrarianLogin();
                            break;
                        case 2:
                            MemberUI memberUI = new MemberUI();
                            memberUI.MemberLogin();
                            break;
                        case 3:
                            loop = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Enter a valid input...");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
                catch (FormatException)
                {
                    loop = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            
        }
    }
}
