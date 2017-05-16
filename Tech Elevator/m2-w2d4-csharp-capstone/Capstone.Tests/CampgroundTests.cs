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
    public class CampgroundTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=DESKTOP-6JSSBN8\SQLEXPRESS;Initial Catalog=Campgrounds;Integrated Security=True";
        // private int test_campground_id = 0;

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

                /////////////////////////
                // I'm not sure what I'm doing wrong but I am unable to get inserts work properly
                /////////////////////////



                // Insert campground
                
                //cmd = new SqlCommand("SET IDENTITY_INSERT campground ON;", conn);

                //cmd = new SqlCommand("INSERT INTO park VALUES (40, 'Test Park', 'Test State', 1900, 10000, 10000, 'Sample description of Test Park');", conn);
                //cmd.ExecuteNonQuery();
                //cmd = new SqlCommand("INSERT INTO campground VALUES (100, 1, 'Test Campground', 1, 12, 100); SELECT CAST(SCOPE_IDENTITY() as int)", conn);
                //cmd = new SqlCommand("SET IDENTITY_INSERT campground OFF;", conn);
                //cmd.ExecuteNonQuery();

                //cmd = new SqlCommand("SELECT COUNT(*) FROM campground WHERE name='Test Campground';", conn);
                //int moretest = (int)cmd.ExecuteScalar();

                //cmd = new SqlCommand("SELECT COUNT(*) FROM campground WHERE name='Blackwoods';", conn);
                //test_campground_id = (int)cmd.ExecuteScalar();

                //// Update department

                //cmd = new SqlCommand("UPDATE department SET department.name='new_department_name' WHERE department.department_id=5;", conn);
                //cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod]
        public void GetDailyFeeTest()
        {
            CampgroundSqlDAL dal = new CampgroundSqlDAL(connectionString);

            List<Campground> campground = dal.GetDailyFee(1);

            Assert.AreEqual(1, campground.Count);
            Assert.AreEqual(35, campground[0].DailyFee);

        }

        [TestMethod]
        public void ShowAllCampgroundsTest()
        {
            CampgroundSqlDAL dal = new CampgroundSqlDAL(connectionString);
            List<Campground> campground = dal.ShowAllCampgrounds();


            Assert.AreEqual(7, campground.Count);
            Assert.AreEqual("Canyon Wren Group Site", campground[1].Name);
        }

        [TestMethod]
        public void ShowAllCampgroundsInAParkTest()
        {
            CampgroundSqlDAL dal = new CampgroundSqlDAL(connectionString);

            int park_id_1 = 1;
            int park_id_2 = 2;
            int park_id_3 = 3;

            List<Campground> test1 = dal.ShowAllCampgroundsInAPark(park_id_1);
            List<Campground> test2 = dal.ShowAllCampgroundsInAPark(park_id_2);
            List<Campground> test3 = dal.ShowAllCampgroundsInAPark(park_id_3);

            Assert.AreEqual(3, test1.Count);
            Assert.AreEqual(35, test1[0].DailyFee);
            Assert.AreEqual(3, test2.Count);
            Assert.AreEqual(1, test3.Count);
        }
    }
}
