using Library.App.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.DAL
{
    public class MemberDAL
    {
        // Init List as repo
        private static List<Member> menbers = new List<Member>()
        {
            new Member   // Seed
            {
                MemberId = 1,
                
                Age = 20,
                Email = "staff0001@gmail.com",
                Password = "1234",
                Phonenumber = "",
                Username = "staff001"
            },
            new Member   // Seed
            {
                MemberId = 2,               
                Age = 20,             
                Email = "student1@gmail.com",
                Password = "1234",
                Phonenumber = "",
                Username = "gcd0001"
            },
        };

        //

    }
}
