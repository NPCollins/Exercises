using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
         The Fibonacci numbers are the integers in the following sequence:  
	        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
         By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
 
         Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.
  
         C:\Users> Fiboncci
         Please enter the Fibonacci number: 25
         
         0, 1, 1, 2, 3, 5, 8, 13, 21
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number please.");
            string fibbInput = Console.ReadLine();
            int fibbInputInt = int.Parse(fibbInput);
            Console.WriteLine("0, ");
            int j = 1;
            int k = 2;
            for(int i = 1; i < fibbInputInt; i += 0)
            {
                if (i == 0 || i == 1)
                {
                    i = i + 1;
                    Console.WriteLine("1, ");
                    Console.WriteLine("1, ");
                }
                else
                {
                    if (i == k)
                    {
                        i = i + j;
                        j = i;
                    }
                    else if (i == j)
                    {
                        i = i + k;
                        k = i;
                    }
                    // I is the current fibb number
                    if (i >= fibbInputInt)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(i + ", ");
                    }
                }

            }
        }
    }
}
