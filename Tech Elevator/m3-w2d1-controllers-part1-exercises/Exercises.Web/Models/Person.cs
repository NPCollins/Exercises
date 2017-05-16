using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Format { get; set; }
        public string Red { get; set; }
        public string Blue { get; set; }
        public string Green { get; set; }


        public Person()
        {

        }

        public Person(string firstName, string lastName, string red, string green, string blue)
        {
            FirstName = firstName;
            LastName = lastName;
            Red = red;
            Blue = blue;
            Green = green;
        }

        public Person(string firstName, string lastName, string middleInitial, string format)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleInitial = middleInitial;
            Format = format;

        }
    }
}