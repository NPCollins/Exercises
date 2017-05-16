using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPrimeFactors
    {

        //## Kata Prime Factor

        //Factorize a positive integer number into its prime factors.
        //Use the TDD approach to write tests that call a single method `Factorize()`.
        //Given a positive integer input n, return its prime factors.
        //1 is always omitted from the result set.

        //2 -> returns[2]
        //3 -> returns[3]
        //4 -> returns[2, 2]
        //6 -> returns[2, 3]
        //7 -> returns[7]
        //8 -> returns[2, 2, 2]
        //9 -> returns[3, 3]
        //10 -> returns[2, 5]

        public int[] Factorize(long input)
        {
            List<int> primeFactorList = new List<int>();
            for(int i = 2; i < input; i++)
            {
                if (i % 1 == 0)
                {
                    while(input % i == 0)
                    {
                        input /= i;
                        primeFactorList.Add(i);
                    }
                }
            }
        }
    }
}
