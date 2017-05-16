using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class LoopsAndArrayExercisesTests
    {
        //CollectionAssert
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object

        LoopsAndArrayExercises exercises = new LoopsAndArrayExercises();

        /*
         Given an array of ints length 3, figure out which is larger between the first and last elements 
         in the array, and set all the other elements to be that value. Return the changed array.
         maxEnd3([1, 2, 3]) → [3, 3, 3]
         maxEnd3([11, 5, 9]) → [11, 11, 11]
         maxEnd3([2, 11, 3]) → [3, 3, 3]
         */

        [TestMethod]
        public void maxEnd3()
        {
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MaxEnd3(new int[] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, exercises.MaxEnd3(new int[] { 11, 5, 9 }));
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MaxEnd3(new int[] { 2, 11, 3 }));
        }

        /*
        Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle 
        elements.
        middleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
        middleWay([7, 7, 7], [3, 8, 0]) → [7, 8]
        middleWay([5, 2, 9], [1, 4, 5]) → [2, 4]
        */

        [TestMethod]
        public void middleWay()
        {
            CollectionAssert.AreEqual(new int[] { 2, 5 }, exercises.MiddleWay(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
            CollectionAssert.AreEqual(new int[] { 7, 8 }, exercises.MiddleWay(new int[] { 7, 7, 7 }, new int[] { 3, 8, 0 }));
            CollectionAssert.AreEqual(new int[] { 2, 4 }, exercises.MiddleWay(new int[] { 5, 2, 9 }, new int[] { 1, 4, 5 }));
        }

    }
}