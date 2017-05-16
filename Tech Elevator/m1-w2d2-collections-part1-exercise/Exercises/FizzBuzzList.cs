using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of Integers, return a List that contains the same Integers (as Strings). Except any multiple of 3
         should be replaced by the String "Fizz", any multiple of 5 should be replaced by the String "Buzz",
         and any multiple of both 3 and 5 should be replaced by the String "FizzBuzz"
         ** INTERVIEW QUESTION **

         fizzBuzzList( {1, 2, 3} )  ->  ["1", "2", "Fizz"]
         fizzBuzzList( {4, 5, 6} )  ->  ["4", "Buzz", "Fizz"]
         fizzBuzzList( {7, 8, 9, 10, 11, 12, 13, 14, 15} )  ->  ["7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]
         
         HINT: To convert an integer x to a string you can call x.ToString() in your code (e.g. if x = 1 then x.ToString() equals "1")
         */
        public List<string> FizzBuzzList(int[] integerArray)
        {
            List<int> integerList = new List<int>();
            List<string> stringList = new List<string>();
            integerList.AddRange(integerArray);
            for (int i = 0; i < integerList.Count; i++)
            {
                if (integerList[i] % 3 != 0 && integerList[i] % 5 != 0)
                {
                    stringList.Add(integerList[i].ToString());
                }
                else if (integerList[i] % 3 == 0 && integerList[i] % 5 == 0)
                {
                    stringList.Add("FizzBuzz");
                }
                else if (integerList[i] % 3 == 0)
                {
                    stringList.Add("Fizz");
                }
                else if (integerList[i] % 5 == 0)
                {
                    stringList.Add("Buzz");
                }
            }
            return stringList;
        }

    }
}
