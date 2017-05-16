using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeChange
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.
 
        C:\Users> MakeChange
         
        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of the bill:");
            string billAmount = Console.ReadLine();
            Console.WriteLine("Please enter the amount tendered:");
            string tenderedAmount = Console.ReadLine();
            decimal billAmountInt = decimal.Parse(billAmount);
            decimal tenderedAmountInt = decimal.Parse(tenderedAmount);
            if (tenderedAmountInt < billAmountInt)
            {
                Console.WriteLine("That isn't enough money you stupid idiot!");
            }
            else
            {
                Console.WriteLine($"The change required is {tenderedAmountInt - billAmountInt}");
            }
        }
    }
}
