using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {

        WordCount exercises = new WordCount();

        [TestMethod]

        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the 
         * number of times that string appears in the array.
         * 
         * ** A CLASSIC **
         * 
         * GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * GetCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * GetCount([]) → {}
         * GetCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         * 
         */

        public void WordCount()
        {

            Dictionary<string, int> testCase1 = new Dictionary<string, int>();
            testCase1.Add("ba", 2);
            testCase1.Add("black", 1);
            testCase1.Add("sheep", 1);
            CollectionAssert.AreEqual(testCase1,exercises.GetCount(new string[] {"ba", "ba", "black", "sheep" }));

            Dictionary<string, int> testCase2 = new Dictionary<string, int>();
            testCase2.Add("a", 2);
            testCase2.Add("b", 2);
            testCase2.Add("c", 1);
            CollectionAssert.AreEqual(testCase2, exercises.GetCount(new string[] { "a", "b", "a", "c", "b" }));

            Dictionary<string, int> testCase3 = new Dictionary<string, int>();
            CollectionAssert.AreEqual(testCase3, exercises.GetCount(new string[] { }));
        }
    }
}
