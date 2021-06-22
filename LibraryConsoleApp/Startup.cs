using Library.App.DAL;
using Library.App.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App
{
    public class Startup
    {
        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection()
                .AddSingleton<IBook, BookDAL>()
                .BuildServiceProvider();

            return provider;
        }
    }
}
