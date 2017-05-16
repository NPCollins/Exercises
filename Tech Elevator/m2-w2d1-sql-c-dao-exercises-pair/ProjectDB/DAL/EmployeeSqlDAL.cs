using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectDB.DAL
{
    public class EmployeeSqlDAL
    {
        private const string SQL_Employees = "SELECT employee.employee_id, employee.department_id, employee.first_name, employee.last_name, employee.job_title, employee.birth_date, employee.gender, employee.hire_date FROM employee ORDER BY employee.employee_id;";
        private const string SQL_SearchEmployees = "SELECT employee.employee_id, employee.department_id, employee.first_name, employee.last_name, employee.job_title, employee.birth_date, employee.gender, employee.hire_date FROM employee where employee.first_name = @first_name and employee.last_name = @last_name ORDER BY employee.employee_id;";
        private const string SQL_EmployeesWithoutProjects = "SELECT employee.employee_id, employee.department_id, employee.first_name, employee.last_name, employee.job_title, employee.birth_date, employee.gender, employee.hire_date FROM employee WHERE employee.employee_id NOT IN(SELECT project_employee.employee_id FROM project_employee WHERE project_employee.employee_id = employee.employee_id)";
        private string connectionString;

        // Single Parameter Constructor
        public EmployeeSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> output = new List<Employee>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_Employees, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee e = new Employee();
                        e.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        e.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        e.FirstName = Convert.ToString(reader["first_name"]);
                        e.LastName = Convert.ToString(reader["last_name"]);
                        e.JobTitle = Convert.ToString(reader["job_title"]);
                        e.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                        e.Gender = Convert.ToString(reader["gender"]);
                        e.HireDate = Convert.ToDateTime(reader["hire_date"]);


                        output.Add(e);
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

        public List<Employee> Search(string firstname, string lastname)
        {
            List<Employee> output = new List<Employee>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_SearchEmployees, conn);

                    cmd.Parameters.AddWithValue("@first_name", firstname);
                    cmd.Parameters.AddWithValue("@last_name", lastname);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee e = new Employee();
                        e.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        e.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        e.FirstName = Convert.ToString(reader["first_name"]);
                        e.LastName = Convert.ToString(reader["last_name"]);
                        e.JobTitle = Convert.ToString(reader["job_title"]);
                        e.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                        e.Gender = Convert.ToString(reader["gender"]);
                        e.HireDate = Convert.ToDateTime(reader["hire_date"]);


                        output.Add(e);
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

        public List<Employee> GetEmployeesWithoutProjects()
        {
            List<Employee> output = new List<Employee>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_EmployeesWithoutProjects, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee e = new Employee();
                        e.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        e.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        e.FirstName = Convert.ToString(reader["first_name"]);
                        e.LastName = Convert.ToString(reader["last_name"]);
                        e.JobTitle = Convert.ToString(reader["job_title"]);
                        e.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                        e.Gender = Convert.ToString(reader["gender"]);
                        e.HireDate = Convert.ToDateTime(reader["hire_date"]);


                        output.Add(e);
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
    }
}
