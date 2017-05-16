using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectDB.DAL
{
    public class DepartmentSqlDAL
    {
        private const string SQL_Departments = "SELECT department.department_id, department.name FROM department ORDER BY department.department_id;";
        private const string SQL_InsertDepartment = @"INSERT INTO department VALUES (@name);";
        private const string SQL_UpdateDepartment = @"UPDATE department SET department.name = @name where department.department_id = @department_id";
        private string connectionString;

        // Single Parameter Constructor
        public DepartmentSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Department> GetDepartments()
        {
            List<Department> output = new List<Department>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_Departments, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Department d = new Department();
                        d.Id = Convert.ToInt32(reader["department_id"]);
                        d.Name = Convert.ToString(reader["name"]);


                        output.Add(d);
                    }
                }
            }
            catch (SqlException ex)
            {
                //Log and throw the exception
                throw;
            }

            return output;
        }
  
        public bool CreateDepartment(Department newDepartment)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_InsertDepartment, conn);

                    cmd.Parameters.AddWithValue("@name", newDepartment.Name);
                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                //Log and throw the exception
                throw;
            }
        }

        public bool UpdateDepartment(Department updatedDepartment)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_UpdateDepartment, conn);

                    cmd.Parameters.AddWithValue("@name", updatedDepartment.Name);
                    cmd.Parameters.AddWithValue("@department_id", updatedDepartment.Id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                //Log and throw the exception
                throw;
            }
        }

    }
}
