using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        private List<string> fizzBuzzList;
        public List<string> FizzBuzzList
        {
            get
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        fizzBuzzList.Add("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        fizzBuzzList.Add("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        fizzBuzzList.Add("Buzz");
                    }
                    else
                    {
                        fizzBuzzList.Add(i.ToString());
                    }
                }
                return fizzBuzzList;
            }
        }
        


        
    }
}
