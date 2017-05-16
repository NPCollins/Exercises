using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;
using System.Data.SqlClient;
using ProjectDB.Models;
using ProjectDB.DAL;

namespace Project_DB_Test
{
    [TestClass]
    public class EmployeeSqlDALTest
    {
        private TransactionScope tran;      //<-- used to begin a transaction during initialize and rollback during cleanup
        private string connectionString = @"Data Source=DESKTOP-6JSSBN8\SQLEXPRESS;Initial Catalog=ProjectOrganizer;Integrated Security=True";

        // Set up the database before each test        
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
                // Insert department

                //cmd = new SqlCommand("INSERT INTO department VALUES ('current_department_name')", conn);
                //cmd.ExecuteNonQuery();

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

        [TestMethod()]
        public void GetEmployeeTest()
        {
            // Arrange 
            EmployeeSqlDAL employeeDAL = new EmployeeSqlDAL(connectionString);

            List<Employee> employeeList = employeeDAL.GetAllEmployees();

            //Assert
            Assert.AreEqual(12, employeeList.Count);
            Assert.AreEqual("Henderson", employeeList[1].LastName);
            Assert.AreEqual("Flo", employeeList[1].FirstName);

        }

        [TestMethod()]
        public void SearchTest()
        {
            // Arrange 
            EmployeeSqlDAL employeeDAL = new EmployeeSqlDAL(connectionString);

            int count = employeeDAL.Search("Flo", "Henderson").Count;

            ////Assert
            Assert.AreEqual(1, count);
        }

        [TestMethod()]
        public void EmployeesWithoutProjectsTest()
        {
            // Arrange 
            EmployeeSqlDAL employeeDAL = new EmployeeSqlDAL(connectionString);

            int count = employeeDAL.GetEmployeesWithoutProjects().Count;

            ////Assert
            Assert.AreEqual(2, count);
        }
    }
}
