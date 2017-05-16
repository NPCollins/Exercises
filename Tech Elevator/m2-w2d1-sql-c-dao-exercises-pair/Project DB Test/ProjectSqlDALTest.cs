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
    public class ProjectSqlDALTest
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
        public void GetAllProjectsTest()
        {
            // Arrange 
            ProjectSqlDAL projectDAL = new ProjectSqlDAL(connectionString);

            List<Project> projectList = projectDAL.GetAllProjects();

            //Assert
            Assert.AreEqual(6, projectList.Count);
        }

        [TestMethod()]
        public void AssignEmployeesTest()
        {
            // Arrange 
            ProjectSqlDAL projectDal = new ProjectSqlDAL(connectionString);

            int project_id = 1;
            int employee_id = 4;


            bool didWork = projectDal.AssignEmployeeToProject(project_id, employee_id);

            Assert.IsTrue(didWork);

        }

        [TestMethod()]
        public void RemoveEmployeeTest()
        {
            // Arrange 
            ProjectSqlDAL projectDal = new ProjectSqlDAL(connectionString);

            int project_id = 3;
            int employee_id = 1;


            bool didWork = projectDal.RemoveEmployeeFromProject(project_id, employee_id);

            Assert.IsTrue(didWork);

        }

        [TestMethod()]
        public void CreateProjectTest()
        {
            // Arrange 
            ProjectSqlDAL projectDal = new ProjectSqlDAL(connectionString);

            DateTime startDate = new DateTime(2016, 6, 21);
            DateTime endDate = new DateTime(2016, 7, 20);

            Project newproject = new Project
            {
                Name = "Fun Project",
                StartDate = startDate,
                EndDate = endDate
            };



            bool didWork = projectDal.CreateProject(newproject);

            Assert.IsTrue(didWork);

        }
    }
}
