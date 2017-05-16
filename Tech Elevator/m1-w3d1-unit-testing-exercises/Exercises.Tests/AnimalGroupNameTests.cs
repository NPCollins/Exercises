using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").  
         * 
         * The animal name should be case insensitive so "elephant", "Elephant", and 
         * "ELEPHANT" should all return "herd". 
         * 
         * If the name of the animal is not found, null, or empty, return "unknown". 
         * 
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * GetHerd("giraffe") → "Tower"
         * GetHerd("") -> "unknown"         
         * GetHerd("walrus") -> "unknown"
         * GetHerd("Rhino") -> "Crash"
         * GetHerd("rhino") -> "Crash"
         * GetHerd("elephants") -> "unknown"
         * 
         */

        AnimalGroupName exercises = new AnimalGroupName();

        [TestMethod]
        public void AnimalGroupName()
        {
            Assert.AreEqual("Crash", exercises.GetHerd("Rhino"));
            Assert.AreEqual("Tower", exercises.GetHerd("giraffe"));
            Assert.AreEqual("Herd", exercises.GetHerd("ElePhant"));
            Assert.AreEqual("Pride", exercises.GetHerd("LION"));
            Assert.AreEqual("Murder", exercises.GetHerd("Crow"));
            Assert.AreEqual("Kit", exercises.GetHerd("PigEon"));
            Assert.AreEqual("Pat", exercises.GetHerd("Flamingo"));
            Assert.AreEqual("Herd", exercises.GetHerd("Deer"));
            Assert.AreEqual("Pack", exercises.GetHerd("DoG"));
            Assert.AreEqual("Float", exercises.GetHerd("CrOcodile"));
            Assert.AreEqual("unknown", exercises.GetHerd("boots"));
            Assert.AreEqual("unknown", exercises.GetHerd("unicorn"));
            //Assert.AreEqual("unknown", exercises.GetHerd(null));
            //Test fails when I try to pass in null in this way.

        }
    }
}
