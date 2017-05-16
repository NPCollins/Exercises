using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechElevator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace TechElevator.Classes.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void ShoppingCart_RequiredMembers()
        {
            Type type = typeof(ShoppingCart);
            ShoppingCart cart = (ShoppingCart)Activator.CreateInstance(type);

            FieldInfo fi = type.GetField("totalNumberOfItems");
            Assert.IsNotNull(fi, "Shopping cart needs a totalNumberOfItems variable.");
            Assert.AreEqual(typeof(int), fi.FieldType, "totalNumberOfItems should be type: int");

            fi = type.GetField("totalAmountOwed");
            Assert.IsNotNull(fi, "Shopping cart needs a totalAmountOwed variable.");
            Assert.AreEqual(typeof(double), fi.FieldType, "totalAmountOwed should be type: double");

            MethodInfo mi = type.GetMethod("GetAveragePricePerItem");
            Assert.IsNotNull(mi, "Shopping cart class needs the GetAveragePricePerItem method.");
            Assert.AreEqual(typeof(double), mi.ReturnType, "GetAveragePricePerItem() method needs to return type: double");
            Assert.AreEqual(0, mi.GetParameters().Length, "GetAveragePricePerItem() should have no parameters");

            mi = type.GetMethod("AddItems");
            Assert.IsNotNull(mi, "Shopping cart class needs the AddItems method.");
            Assert.AreEqual(typeof(void), mi.ReturnType, "AddItems() method needs to return type: void");
            Assert.AreEqual(2, mi.GetParameters().Length);

            mi = type.GetMethod("Empty");
            Assert.IsNotNull(mi, "Shopping cart class needs the Empty method.");
            Assert.AreEqual(typeof(void), mi.ReturnType, "Empty() method needs to return type: void");
            Assert.AreEqual(0, mi.GetParameters().Length);
        }


        [TestMethod()]
        public void ShoppingCart_DefaultCart()
        {
            Type type = typeof(ShoppingCart);
            ShoppingCart cart = (ShoppingCart)Activator.CreateInstance(type);

            FieldInfo fi = type.GetField("totalNumberOfItems");
            Assert.AreEqual(0, fi.GetValue(cart), "totalNumberOfItems should be 0 for new carts.");

            fi = type.GetField("totalAmountOwed");
            Assert.AreEqual(0.0, fi.GetValue(cart), "totalAmountOwed should be 0.0 for new carts.");
        }

        [TestMethod]
        public void ShoppingCart_GetAveragericePerItem()
        {
            Type type = typeof(ShoppingCart);
            ShoppingCart cart = (ShoppingCart)Activator.CreateInstance(type);
            MethodInfo mi = type.GetMethod("GetAveragePricePerItem");

            type.GetField("totalNumberOfItems").SetValue(cart, 0);
            type.GetField("totalAmountOwed").SetValue(cart, 0.0);

            Assert.AreEqual(0.0, mi.Invoke(cart, null), "The average price per item of an empty cart is 0.0");

            type.GetField("totalNumberOfItems").SetValue(cart, 2);
            type.GetField("totalAmountOwed").SetValue(cart, 5);

            Assert.AreEqual(2.5, mi.Invoke(cart, null), "The average price per item is totalAmountOwed / totalNumberOfItems");
        }

        

        [TestMethod()]
        public void ShoppingCart_AddItemTest()
        {
            Type type = typeof(ShoppingCart);
            ShoppingCart cart = (ShoppingCart)Activator.CreateInstance(type);
            MethodInfo mi = type.GetMethod("AddItems");

            //Reset the cart
            type.GetField("totalNumberOfItems").SetValue(cart, 0);
            type.GetField("totalAmountOwed").SetValue(cart, 0.0);

            mi.Invoke(cart, new object[] { 2, 2.10 });

            Assert.AreEqual(2, type.GetField("totalNumberOfItems").GetValue(cart), "AddItems should add numberOfItems to totalNumberOfItems");
            Assert.AreEqual(4.20, type.GetField("totalAmountOwed").GetValue(cart), "AddItems should add pricePerItem * numberOfItems to totalAmountOwed");

        }

        [TestMethod()]
        public void ShoppingCart_EmptyTest()
        {
            Type type = typeof(ShoppingCart);
            ShoppingCart cart = (ShoppingCart)Activator.CreateInstance(type);
            MethodInfo mi = type.GetMethod("Empty");

            //Reset the cart
            type.GetField("totalNumberOfItems").SetValue(cart, 5);
            type.GetField("totalAmountOwed").SetValue(cart, 10.0);

            mi.Invoke(cart, null);

            Assert.AreEqual(0, type.GetField("totalNumberOfItems").GetValue(cart), "Empty should reset totalNumberOfItems to 0");
            Assert.AreEqual(0.0, type.GetField("totalAmountOwed").GetValue(cart), "Empty should reset totalAmountOwed to 0.0");

        }
        
    }
}