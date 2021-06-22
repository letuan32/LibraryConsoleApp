using Library.App;
using Library.App.BLL;
using Library.App.DAL;
using Library.App.Entities;
using Library.App.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace LibraryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //var container = Startup.ConfigureService();
            //var bookService = container.GetRequiredService<IBook>();

            BookBLL bookBLL = new BookBLL(new BookDAL());

            List<Book> listBook = bookBLL.GetBooks();

            foreach(Book book in listBook)
            {
                Console.WriteLine("ID = {0}, Title = {1}", book.Id, book.Title);
            }

            Console.WriteLine("Hello World!");

        }
    }
}
