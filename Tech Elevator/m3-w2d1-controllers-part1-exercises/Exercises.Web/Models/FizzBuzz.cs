using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
    public class FizzBuzz
    {
        public int Divisor1 { get; set; }
        public int Divisor2 { get; set; }
        public string AltFizz { get; set; }
        public string AltBuzz { get; set; }
        public string AltFizzBuzz { get { return AltFizz + AltBuzz + "!"; } }
        private List<int> numberList = new List<int>();
        public List<int> NumberList
        {
            get { return numberList; }
            set { numberList = value; }
        }
    }
}