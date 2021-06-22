using Library.App;
using Library.App.BLL;
using Library.App.DAL;
using Library.App.Entities;
using Library.App.Service;
using Library.App.UI;
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

            StartUI newUI = new StartUI();
            newUI.StartMenu();

        }
    }
}
