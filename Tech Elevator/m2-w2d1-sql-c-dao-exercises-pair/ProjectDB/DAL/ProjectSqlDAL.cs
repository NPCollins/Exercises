using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectDB.DAL
{
    public class ProjectSqlDAL
    {
        private const string SQL_Projects = "SELECT project.project_id, project.name, project.from_date, project.to_date FROM project ORDER BY project.project_id;";
        private const string SQL_EmployeeToProject = @"INSERT INTO project_employee values (@projectId, @employeeId);";
        private const string SQL_EmployeeFromProject = @"DELETE FROM project_employee WHERE project_employee.employee_id = @employeeId and project_employee.project_id = @projectId;";
        private const string SQL_InsertProject = @"INSERT INTO project VALUES (@name, @StartDate, @EndDate);";
        private string connectionString;

        // Single Parameter Constructor
        public ProjectSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Project> GetAllProjects()
        {
            {
                List<Project> output = new List<Project>();

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(SQL_Projects, conn);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Project p = new Project();
                            p.ProjectId = Convert.ToInt32(reader["project_id"]);
                            p.Name = Convert.ToString(reader["name"]);
                            p.StartDate = Convert.ToDateTime(reader["from_date"]);
                            p.EndDate = Convert.ToDateTime(reader["to_date"]);


                            output.Add(p);
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

        public bool AssignEmployeeToProject(int projectId, int employeeId)
        {
            List<Project> output = new List<Project>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_EmployeeToProject, conn);

                    cmd.Parameters.AddWithValue("@projectId", projectId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);

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

        public bool RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            List<Project> output = new List<Project>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_EmployeeFromProject, conn);

                    cmd.Parameters.AddWithValue("@projectId", projectId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);

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

        public bool CreateProject(Project newProject)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_InsertProject, conn);

                    cmd.Parameters.AddWithValue("@name", newProject.Name);
                    cmd.Parameters.AddWithValue("@startDate", newProject.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", newProject.EndDate);

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
