using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.UI
{
    public class MemberUI
    {
        // 
        public void MemberLogin()
        {

        }

        // Member management 
        private void GetMemberManagementMenu()
        {
            Console.WriteLine("1) Get all member\n" +
                "2) Add member\n" +
                "3) Delete member\n" +
                "4) Updater member\n" +
                "5) Get member by id \n" +
                "6) Exit");
        }
        private void AddMember()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Developing......");
        }
        private void DeleteMember()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Developing......");
        }

        private void UpdateMember()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Developing......");
        }
        private void GetAllMember()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Developing......");
        }
        private void GetMemberById() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Developing......");
        }

        public void MemberManagementMenu() 
        {
            bool loop = true;
            while (loop == true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t-----------Members Management-------------");
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    GetMemberManagementMenu();
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            GetAllMember();
                            break;
                        case 2:
                            AddMember();
                            break;
                        case 3:
                            DeleteMember();
                            break;
                        case 4:
                            UpdateMember();
                            break;
                        case 5:
                            GetMemberById();
                            break;
                        case 6:
                            Console.WriteLine("");
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
        }


    }
}
