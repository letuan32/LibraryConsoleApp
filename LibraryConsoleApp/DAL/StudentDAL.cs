using Library.App.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.App.DAL
{
    public class StudentDAL
    {
        //Init list
        private static List<Student> students = new List<Student>()
        {
            new Student   // Seed
            {
                StudentId = "GCD0001", 
                Age = 20, 
                Class = "Class1", 
                Email = "student1@gmail.com", 
                Password = "1234",
                Phonenumber = "",
                Username = "gcd0001"
            },
            new Student
            {
                StudentId = "GCD0009",
                Age = 22,
                Class = "Class1",
                Email = "student9@gmail.com",
                Password = "1234",
                Phonenumber = "",
                Username = "gcd0009"
            }
        };



       
        
    }

   
}
