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
    public class CompanyTests
    {
        [TestMethod]
        public void Company_CheckRequiredMembers()
        {
            Type type = typeof(Company);
            Company company = (Company)Activator.CreateInstance(type);

            FieldInfo fi = type.GetField("name");
            Assert.IsNotNull(fi, "A field called name needs to exist");
            Assert.AreEqual(typeof(string), fi.FieldType, "The name field needs to be type: string");

            fi = type.GetField("numberOfEmployees");
            Assert.IsNotNull(fi, "A field called numberOfEmployees needs to exist");
            Assert.AreEqual(typeof(int), fi.FieldType, "The numberOfEmployees field needs to be type: int");

            fi = type.GetField("revenue");
            Assert.IsNotNull(fi, "A field called revenue needs to exist");
            Assert.AreEqual(typeof(decimal), fi.FieldType, "The revenue field needs to be type: decimal");

            fi = type.GetField("expenses");
            Assert.IsNotNull(fi, "A field called expenses needs to exist");
            Assert.AreEqual(typeof(decimal), fi.FieldType, "The expenses field needs to be type: decimal");

            MethodInfo mi = type.GetMethod("GetCompanySize");
            Assert.IsNotNull(mi, "A method called GetCompanySize needs to be included");
            Assert.AreEqual(typeof(string), mi.ReturnType, "The GetCompanySize() method needs to be type: string");

            mi = type.GetMethod("GetProfit");
            Assert.IsNotNull(mi, "A method called GetProfit needs to be included");
            Assert.AreEqual(typeof(decimal), mi.ReturnType, "The GetProfit() method needs to be type: decimal");
        }

        [TestMethod]
        public void Company_CompanySizeTests()
        {
            Type type = typeof(Company);
            Company company = (Company)Activator.CreateInstance(type);

            FieldInfo fi = type.GetField("numberOfEmployees");
            MethodInfo mi = type.GetMethod("GetCompanySize");

            fi.SetValue(company, 49);            
            Assert.AreEqual("small", mi.Invoke(company, null), "Company Size should be 'small' when employees are less than 50");

            fi.SetValue(company, 50);
            Assert.AreEqual("medium", mi.Invoke(company, null), "Company Size should be 'medium' when employees are between 50 and 250");

            fi.SetValue(company, 251);
            Assert.AreEqual("large", mi.Invoke(company, null), "Company Size should be 'large' when employees are greater than 250");            
        }

        [TestMethod]
        public void Company_ProfitTests()
        {
            Type type = typeof(Company);
            Company company = (Company)Activator.CreateInstance(type);

            type.GetField("revenue").SetValue(company, 125.51M);
            type.GetField("expenses").SetValue(company, 2.50M);

            MethodInfo mi = type.GetMethod("GetProfit");
            Assert.AreEqual(123.01M, mi.Invoke(company, null), "GetProfit() should return difference between revenue and expenses.");
        }
    }
}
