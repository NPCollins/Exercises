﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Count the number of "xx" in the given string. We'll say that overlapping is allowed, so "xxx" contains 2 "xx".
         countXX("abcxx") → 1
         countXX("xxx") → 2
         countXX("xxxx") → 
         */
        public int CountXX(string str)
        {
            int x = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 1) == "x" && str.Substring( (i + 1), 1) == "x")
                {
                    x++;
                }
            }
            return x;
        }
    }
}
