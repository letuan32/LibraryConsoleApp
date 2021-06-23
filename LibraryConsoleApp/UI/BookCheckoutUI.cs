using ConsoleTables;
using Library.App.BLL;
using Library.App.DAL;
using Library.App.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.UI
{
    public class BookCheckoutUI
    {
        private List<BookCheckout> records = new List<BookCheckout>();
        private BookCheckout record;
        // Get book checkout menu
        private void GetBookCheckoutMenu()
        {
            Console.WriteLine("1) Get all record\n" +
                "2) Add a record\n" +
                "3) Delete a record\n" +
                "4) Update a record status\n" +
                "5) Get record by book title \n" +
                "6) Exit\n");
        }
        // Get all record
        private void GetAllRecord()
        {
            BookCheckoutBLL bookCheckoutBLL = new BookCheckoutBLL(new BookCheckoutDAL());
            records = bookCheckoutBLL.GetAll();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t-----------------------------Record list---------------------------");
            ConsoleTable.From<BookCheckout>(records).Write();
            Console.ForegroundColor = ConsoleColor.White;

        }
        // Get record by Title
        private void GetRecordByBookTitle()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Record Id: ");
                string title = Console.ReadLine();
                BookCheckoutBLL bookCheckoutBLL = new BookCheckoutBLL(new BookCheckoutDAL());
                records = bookCheckoutBLL.GetByIBookTitle(title);
                ConsoleTable.From<BookCheckout>(records).Write();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a valid input");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        // Add record
        private void AddRecord()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter record details..");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Record Id: ");
                record.RecordId = int.Parse(Console.ReadLine());
                Console.Write("Member Id: ");
                record.MemberId = int.Parse(Console.ReadLine());
                Console.Write("Borrow Date: ", DateTime.Now.Date);
                record.BorrowDate = DateTime.Now.Date;
                Console.Write("Due Date: ", record.BorrowDate.AddDays(15));
                record.IsReturn = false;
                
                BookCheckoutBLL bookCheckoutBLL = new BookCheckoutBLL(new BookCheckoutDAL());
                bookCheckoutBLL.Add(record);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a valid input");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        // Update record status
        private void UpdateRecordStatus()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Update Record Status..");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Record Id: ");
                record.RecordId = int.Parse(Console.ReadLine());
                Console.Write("Member Id: ");
                record.MemberId = int.Parse(Console.ReadLine());
                Console.Write("Book Title: ");
                record.BookTitle = Console.ReadLine();
                Console.Write("Is returned(yes/no): ");
                string isReturn = Console.ReadLine().ToLower();
                if (isReturn == "yes")
                    record.IsReturn = true;
                else
                    record.IsReturn = false;
                BookCheckoutBLL bookCheckoutBLL = new BookCheckoutBLL(new BookCheckoutDAL());
                bookCheckoutBLL.UpdateById(record.RecordId, record.MemberId, record.BookTitle, record.IsReturn);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a valid input");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        // Delete record
        private void DeleteRecord()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Record Id: ");
                int recordId = int.Parse(Console.ReadLine());
                BookCheckoutBLL bookCheckoutBLL = new BookCheckoutBLL(new BookCheckoutDAL());
                bookCheckoutBLL.DeleteById(recordId);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a valid input");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        // Book checkout menu
        public void BooKCheckoutMenu() 
        {
            bool loop = true;
            while (loop == true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t-----------Library Book Checkout Sheet-------------");
                Console.ForegroundColor = ConsoleColor.White;

                try
                {
                    GetBookCheckoutMenu();
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            GetAllRecord();
                            break;
                        case 2:
                            AddRecord();
                            break;
                        case 3:
                            DeleteRecord();
                            break;
                        case 4:
                            UpdateRecordStatus();
                            break;
                        case 5:
                            GetRecordByBookTitle();
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
