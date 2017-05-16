using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechElevator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Exercises.Tests.Classes
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod]
        public void Product_CheckRequiredMembers()
        {
            Type type = typeof(Product);
            Product product = (Product)Activator.CreateInstance(type);

            FieldInfo fi = type.GetField("name");
            Assert.IsNotNull(fi, "A field called name needs to exist");
            Assert.AreEqual(typeof(string), fi.FieldType, "The name field needs to be type: string");

            fi = type.GetField("price");
            Assert.IsNotNull(fi, "A field called price needs to exist");
            Assert.AreEqual(typeof(decimal), fi.FieldType, "The price field needs to be type: decimal");
            
            fi = type.GetField("weightInOunces");
            Assert.IsNotNull(fi, "A field called weightInOunces needs to exist");
            Assert.AreEqual(typeof(double), fi.FieldType, "The weightInOunces field needs to be type: double");

            
        }

      
    }
}
