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
    public class DepartmentSqlDALTest
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

                cmd = new SqlCommand("INSERT INTO department VALUES ('current_department_name')", conn);
                cmd.ExecuteNonQuery();

                // Update department

                cmd = new SqlCommand("UPDATE department SET department.name='new_department_name' WHERE department.department_id=5;", conn);
                cmd.ExecuteNonQuery();
            }
        }

        // Cleanup runs after every single test
        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }
        [TestMethod()]
        public void GetDepartmentTest()
        {
            // Arrange 
            DepartmentSqlDAL departmentDal = new DepartmentSqlDAL(connectionString);

            List<Department> departmentList = departmentDal.GetDepartments();
          

            //Assert
            Assert.AreEqual(5, departmentList.Count);
            Assert.AreEqual("Network Administration", departmentList[1].Name);

        }
        [TestMethod()]
        public void CreateDepartmentTest()
        {
            // Arrange 
            DepartmentSqlDAL departmentDal = new DepartmentSqlDAL(connectionString);

            Department test1 = new Department
            {
                Id = 5,
                Name = "BrandNewDepartment"
            };  

            //Act
            bool didWork = departmentDal.CreateDepartment(test1); 

            //Assert
            Assert.AreEqual(true, didWork); 

        }

        [TestMethod()]
        public void UpdateDepartmentTest()
        {
            DepartmentSqlDAL departmentDal = new DepartmentSqlDAL(connectionString);

            Department test1 = new Department
            {
                Id = 4,
                Name = "new_department_name"
            };

            Department test2 = new Department
            {
                Id = 11,
                Name = "Department of Redundancy"
            };

            bool didWork = departmentDal.UpdateDepartment(test1);
            bool didWork2 = departmentDal.UpdateDepartment(test2);
            Assert.IsTrue(didWork);
            Assert.IsFalse(didWork2);
        }
    }
}
