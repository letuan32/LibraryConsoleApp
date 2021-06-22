using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.Service
{
    public interface ILibrarian
    {
        //  Get admin 
        bool Login(string username, string password);
        
    }
}
