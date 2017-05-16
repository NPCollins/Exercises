using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {

        StringBits exercises = new StringBits();

        [TestMethod]

        /*
         Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
         GetBits("Hello") → "Hlo"	
         GetBits("Hi") → "H"	
         GetBits("Heeololeo") → "Hello"	
         */

        public void StringBits()
        {
            Assert.AreEqual("Hlo", exercises.GetBits("Hello"));
            Assert.AreEqual("H", exercises.GetBits("Hi"));
            Assert.AreEqual("Hello", exercises.GetBits("Heeololeo"));
            Assert.AreEqual("", exercises.GetBits(""));
            Assert.AreEqual("H", exercises.GetBits("H"));
            Assert.AreEqual("T", exercises.GetBits("To"));
        }
    }
}
