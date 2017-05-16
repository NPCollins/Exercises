using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if it ends in "ly".
         endsLy("oddly") → true
         endsLy("y") → false
         endsLy("oddy") → false
         */
        public bool EndsLy(string str)
        {
            if (str.Length == 1 || str.Length == 0)
            {
                return false;
            }
            else if (str.Substring((str.Length - 2), 2) == "ly")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
