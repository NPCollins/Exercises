using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {

        NonStart exercises = new NonStart();

        [TestMethod]

        /*
         Given 2 strings, return their concatenation, except omit the first char of each. The strings will 
         be at least length 1.
         GetPartialString("Hello", "There") → "ellohere"
         GetPartialString("java", "code") → "avaode"	
         GetPartialString("shotl", "java") → "hotlava"	
         */

        public void NonStart()
        {
            Assert.AreEqual("ellohere", exercises.GetPartialString("Hello", "There"));
            Assert.AreEqual("avaode", exercises.GetPartialString("java", "code"));
            Assert.AreEqual("hotlava", exercises.GetPartialString("shotl", "java"));
            Assert.AreEqual("ava", exercises.GetPartialString("java", ""));
            Assert.AreEqual("lava", exercises.GetPartialString("", "slava"));
        }
    }
}
