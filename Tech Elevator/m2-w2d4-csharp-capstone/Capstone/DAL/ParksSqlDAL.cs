using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capstone.Models;

namespace Capstone.DAL
{
    public class ParksSqlDAL
    {
        //Make a method that displays all the available parks in alphabetical order.
        //Includes: ID, Name, Location, Established Date, Area, Annual Visitor Count, and Description

        //Make a method that displays all of the campgrounds found in a selected park.

        private const string SQL_Parks = "SELECT park.park_id, park.name, park.location, park.establish_date, park.area, park.visitors, park.description FROM park ORDER BY park.name;";
        private const string SQL_ShowOnePark = "SELECT park.park_id, park.name, park.location, park.establish_date, park.area, park.visitors, park.description FROM park WHERE park.park_id = @park_id;";
        private string connectionString;

        public ParksSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Parks> ShowAllParks()
        {
            List<Parks> output = new List<Parks>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_Parks, conn);



                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Parks p = new Parks();
                        p.Id = Convert.ToInt32(reader["park_id"]);
                        p.Name = Convert.ToString(reader["name"]);
                        p.Location = Convert.ToString(reader["location"]);
                        p.EstablishmentDate = Convert.ToDateTime(reader["establish_date"]);
                        p.Area = Convert.ToInt32(reader["area"]);
                        p.Visitors = Convert.ToInt32(reader["visitors"]);
                        p.Description = Convert.ToString(reader["description"]);

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

        public List<Parks> ShowOnePark(int park_id)
        {
            List<Parks> output = new List<Parks>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_ShowOnePark, conn);

                    cmd.Parameters.AddWithValue("@park_id", park_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Parks p = new Parks();
                        p.Id = Convert.ToInt32(reader["park_id"]);
                        p.Name = Convert.ToString(reader["name"]);
                        p.Location = Convert.ToString(reader["location"]);
                        p.EstablishmentDate = Convert.ToDateTime(reader["establish_date"]);
                        p.Area = Convert.ToInt32(reader["area"]);
                        p.Visitors = Convert.ToInt32(reader["visitors"]);
                        p.Description = Convert.ToString(reader["description"]);

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
}
