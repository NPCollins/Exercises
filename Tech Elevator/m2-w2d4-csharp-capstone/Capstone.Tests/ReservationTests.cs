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
    public class ReservationTests
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

        // NOT SURE WHAT A GOOD WAY TO TEST THIS METHOD IS GIVEN THAT IT REQUIRES DATE INPUTS

        //[TestMethod]
        //public void SearchForAReservationTest()
        //{
        //    ReservationSqlDAL dal = new ReservationSqlDAL(connectionString);



        //    DateTime sampleFrom = new DateTime(2017, 02, 27);
        //    DateTime sampleTo = new DateTime(2017, 04, 02);
        //    DateTime sampleCreated = new DateTime(2017, 02, 26, 11, 35, 50);

        //    List<Reservation> res = dal.SearchForAReservation(2, sampleFrom, sampleTo);



        //    Assert.AreEqual(2, res[12].Id);
        //    Assert.AreEqual("Gates Reservation", res[12].Name);
        //}

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

        [TestMethod]
        public void MakeReservationTest()
        {
            ReservationSqlDAL dal = new ReservationSqlDAL(connectionString);

            DateTime startDate = new DateTime(2018, 6, 21);
            DateTime endDate = new DateTime(2018, 7, 20);

            Reservation reservation = new Reservation
            {
                SiteId = 44,
                Name = "Swiss Family Reservation",
                FromDate = startDate,
                ToDate = endDate
            };

            bool didWork = dal.MakeReservation(reservation);

            Assert.IsTrue(didWork);
        }

        [TestMethod]
        public void GetReservationIdTest()
        {
            ReservationSqlDAL dal = new ReservationSqlDAL(connectionString);

            Reservation reservation = new Reservation();

            int res_id = dal.GetReservation_Id();

            Assert.AreEqual(44, res_id);
        }

        [TestMethod]
        public void GetUpcomingReservationsTest()
        {
            ReservationSqlDAL dal = new ReservationSqlDAL(connectionString);

            int park_id = 1;

            List<Reservation> reservation = dal.GetUpcomingReservations(park_id);

            Assert.AreEqual("Eagles Family Reservation", reservation[0].Name);
            Assert.AreEqual(5, reservation[0].Id);
        }
    }
}
