using Library.App.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.DAL
{
    public class StaffDAL
    {
        // Init List
        private static List<Staff> staffs = new List<Staff>()
        {
            new Staff   // Seed
            {
                StaffId = "ST0001",
                Age = 20,
                Email = "staff0001@gmail.com",
                Password = "1234",
                Phonenumber = "",
                Username = "staff001"
            },
           
        };


        
    }
    // Seed
}
