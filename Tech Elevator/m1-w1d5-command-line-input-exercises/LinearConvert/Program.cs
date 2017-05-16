﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConvert
{
    class Program
    {
        /*
         The foot to meter conversion formula is:
 	        m = f * 0.3048
 	
         The meter to foot conversion formula is:
 	        f = m * 3.2808399
 	
         Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet.
         Convert the length to the opposite measurement, and display the old and new measurements to the console.
  
         C:\Users> LinearConvert
         Please enter the length: 58
         Is the measurement in (m)eter, or (f)eet? f
         58f is 17m.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Is your distance in \"feet\" or in \"meters\"?");
            string units = Console.ReadLine();
            Console.WriteLine("Please enter the distance to be converted:");
            string temperatureString = Console.ReadLine();
            double temperatureStringDouble = double.Parse(temperatureString);
            if (units == "feet")
            {
                Console.WriteLine($"Your distance is {temperatureStringDouble * 0.3048} in meters.");
            }
            else if (units == "meters")
            {
                Console.WriteLine($"Your distance is {temperatureStringDouble * 3.2808399} in feet.");
            }
            else
            {
                Console.WriteLine("You typed in your units incorrectly");
            }
        }
        }
    }
