using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {

        SameFirstLast exercises = new SameFirstLast();

        [TestMethod]

        /*
         Given an array of ints, return true if the array is length 1 or more, and the first element and
         the last element are equal.
         IsItTheSame([1, 2, 3]) → false
         IsItTheSame([1, 2, 3, 1]) → true
         IsItTheSame([1, 2, 1]) → true
         */

        public void SameFirstLast()
        {
            Assert.AreEqual(false, exercises.IsItTheSame(new int[] { 1, 2, 3 }));
            Assert.AreEqual(true, exercises.IsItTheSame(new int[] { 1, 2, 3, 1 }));
            Assert.AreEqual(true, exercises.IsItTheSame(new int[] { 1, 2, 1 }));
        }
    }
}
