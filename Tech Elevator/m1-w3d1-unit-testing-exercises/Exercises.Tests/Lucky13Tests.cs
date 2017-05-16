using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        Lucky13 exercises = new Lucky13();

        [TestMethod]


        /*
         Given an array of ints, return true if the array contains no 1's and no 3's.
         GetLucky([0, 2, 4]) → true
         GetLucky([1, 2, 3]) → false
         GetLucky([1, 2, 4]) → false
         */

        public void Lucky13()
        {
            Assert.AreEqual(true, exercises.GetLucky(new int[] { 0, 2, 4}));
            Assert.AreEqual(false, exercises.GetLucky(new int[] { 1, 2, 3 }));
            Assert.AreEqual(false, exercises.GetLucky(new int[] { 1, 2, 4 }));
            Assert.AreEqual(false, exercises.GetLucky(new int[] { 1, 2, 4, 0, 9 }));
            Assert.AreEqual(true, exercises.GetLucky(new int[] { -1, -3, 4 }));

        }
    }
}
