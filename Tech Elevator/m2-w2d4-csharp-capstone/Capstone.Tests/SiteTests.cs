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
    public class SiteTests
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
        public void ShowAllSitesInACampground()
        {
            SiteSqlDAL dal = new SiteSqlDAL(connectionString);

            int campground_id = 7;

            List<Site> site = dal.ShowAllSitesInACampground(campground_id);

            Assert.AreEqual(5, site.Count);
        }

        // not sure how to do SearchAllSitesTest using DateTime
    }
}
