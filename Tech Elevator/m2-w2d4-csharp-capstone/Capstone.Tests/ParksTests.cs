using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Transactions;
using System.Collections.Generic;
using Capstone.DAL;
using Capstone.Classes;
using Capstone.Models;

namespace Capstone.Tests
{
  
  [TestClass]
    public class ParksTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=DESKTOP-6JSSBN8\SQLEXPRESS;Initial Catalog=Campgrounds;Integrated Security=True";

        [TestInitialize]
        public void Initialize()
        {
            // Initialize a new transaction scope. This automatically begins the transaction.
            tran = new TransactionScope();

            // Open a SqlConnection object using the active transaction
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd;

                conn.Open();
            }
        }
        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }
        [TestMethod]
        public void ShowAllParksTest()
        {
            ParksSqlDAL dal = new ParksSqlDAL(connectionString);
            List<Parks> parks = dal.ShowAllParks();


            Assert.AreEqual(3, parks.Count);
            Assert.AreEqual("Acadia", parks[0].Name);
        }

        [TestMethod]
        public void ShowOneParkTest()
        {
            ParksSqlDAL dal = new ParksSqlDAL(connectionString);

            int park_id = 3;

            List<Parks> parks = dal.ShowOnePark(park_id);


            Assert.AreEqual(1, parks.Count);
            Assert.AreEqual("Cuyahoga Valley", parks[0].Name);
            Assert.AreEqual("Ohio", parks[0].Location);
        }
    }
}
