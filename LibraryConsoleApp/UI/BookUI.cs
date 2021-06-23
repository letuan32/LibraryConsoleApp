using ConsoleTables;
using Library.App.BLL;
using Library.App.DAL;
using Library.App.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.UI
{
    public class BookUI
    {
        private Book book = new Book();
        // Book Menu //
        private void GetBookMenu()
        {
            Console.WriteLine("1) Get all book\n" +
                "2) Add a book\n" +
                "3) Delete a book\n" +
                "4) Update a book\n" +
                "5) Get book by id \n" +
                "6) Get book by title \n" +
                "7) Get book by author \n" +
                "8) Exit");
        }

        // Get all book
        private void GetAllBook()
        {
            List<Book> books = new List<Book>();
            BookBLL bookBLL = new BookBLL(new BookDAL());
            books = bookBLL.GetBooks();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t-----------------------------Books-List---------------------------");
            ConsoleTable.From<Book>(books).Write();
            Console.ForegroundColor = ConsoleColor.White;
        }
        // Add book menu
        private void AddBook()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter book details..");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Book Id: ");
                book.Id = int.Parse(Console.ReadLine());
                Console.Write("Book Title: ");
                book.Title = Console.ReadLine();
                Console.Write("Book ISBN: ");
                book.ISBN = Console.ReadLine();
                Console.Write("Book Subject: ");
                book.Subject = Console.ReadLine();
                Console.Write("Book Author: ");
                book.Author = Console.ReadLine();
                Console.Write("Book Language: ");
                book.Language = Console.ReadLine();
                Console.Write("Publisher: ");
                book.Publisher = Console.ReadLine();
                BookBLL addBook = new BookBLL(new BookDAL());
                addBook.AddBook(book);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a valid input");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        // Delete book menu
        private void DeleteBookById()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter book details..");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Book Id: ");
                book.Id = int.Parse(Console.ReadLine());
                BookBLL removeBook = new BookBLL(new BookDAL());
                removeBook.DeleteBook(book.Id);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a valid input");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        // Update book menu
        private void UpdateBook()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter book details..");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Book Id: ");
                book.Id = int.Parse(Console.ReadLine());
                Console.Write("Book Title: ");
                book.Title = Console.ReadLine();
                Console.Write("Book ISBN: ");
                book.ISBN = Console.ReadLine();
                Console.Write("Book Subject: ");
                book.Subject = Console.ReadLine();
                Console.Write("Book Author: ");
                book.Author = Console.ReadLine();
                Console.Write("Book Language: ");
                book.Language = Console.ReadLine();
                Console.Write("Publisher: ");
                book.Publisher = Console.ReadLine();
                //
                BookBLL updateBook = new BookBLL(new BookDAL());
                updateBook.UpdateBook(book);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a valid input");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        // Get book by Id
        private void GetBookById()
        {
            try
            {
                List<Book> books = new List<Book>();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Book Id: ");
                int id = int.Parse(Console.ReadLine());
                BookBLL getBook = new BookBLL(new BookDAL());
                books = getBook.GetBookById(id);
                ConsoleTable.From<Book>(books).Write();
            }
            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a valid input");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            
        }
        // Get book by title
        private void GetBookByTitle()
        {
            try
            {
                List<Book> books = new List<Book>();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Book Title: ");
                string title = Console.ReadLine();
                BookBLL getBook = new BookBLL(new BookDAL());
                books = getBook.GetBookByTitle(title);
                ConsoleTable.From<Book>(books).Write();
            }
            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a valid input");
                Console.ForegroundColor = ConsoleColor.White;
            }



        }
        // Get book by author
        private void GetBookByAuthor()
        {
            try
            {
                List<Book> books = new List<Book>();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Book Author: ");
                string author = Console.ReadLine();
                BookBLL getBook = new BookBLL(new BookDAL());
                books = getBook.GetBookByAuthor(author);
                ConsoleTable.From<Book>(books).Write();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a valid input");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        // Book menu
        public void BookMenu()
        {
            bool loop = true;
            while (loop == true)
            {
                   Console.ForegroundColor = ConsoleColor.Cyan;
                   Console.WriteLine("-----------Book Management-------------");
                   Console.ForegroundColor = ConsoleColor.White;
            
                try
                {
                    GetBookMenu();
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            GetAllBook();
                            break;
                        case 2:
                            AddBook();
                            break;
                        case 3:
                            DeleteBookById();
                            break;
                        case 4:
                            UpdateBook();
                            break;
                        case 5:
                            GetBookById();
                            break;
                        case 6:
                            GetBookByTitle();
                            break;
                        case 7:
                            GetBookByAuthor();
                            break;
                        case 8:
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
