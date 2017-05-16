using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {

        MaxEnd3 exercises = new MaxEnd3();

        [TestMethod]


        public void MaxEnd3()
        {
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MakeArray(new int[] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, exercises.MakeArray(new int[] { 11, 5, 9 }));
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MakeArray(new int[] { 2, 11, 3 }));
        }
    }
}
