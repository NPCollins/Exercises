using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capstone.Models;

namespace Capstone.DAL
{
    public class CampgroundSqlDAL
    {
        private const string SQL_Campgrounds = "SELECT campground.campground_id, campground.park_id, campground.name, campground.open_from_mm, campground.open_to_mm, campground.daily_fee FROM campground ORDER BY campground.name;";
        private const string SQL_ShowCampgroundsInAPark = "SELECT campground.campground_id, campground.park_id, campground.name, campground.open_from_mm, campground.open_to_mm, campground.daily_fee FROM campground WHERE campground.park_id = @park_id ORDER BY campground.name;";
        private const string SQL_DailyFee = "SELECT campground.campground_id, campground.daily_fee FROM campground WHERE campground.campground_id= @campground_id;";
        private string connectionString;

        public CampgroundSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Campground> GetDailyFee(int campground_id)
        {
            List<Campground> output = new List<Campground>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_DailyFee, conn);

                    cmd.Parameters.AddWithValue("@campground_id", campground_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Campground c = new Campground();
                        c.Id = Convert.ToInt32(reader["campground_id"]);
                        c.DailyFee = Convert.ToInt32(reader["daily_fee"]);

                        output.Add(c);
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

        public List<Campground> ShowAllCampgrounds()
        {
            List<Campground> output = new List<Campground>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_Campgrounds, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Campground c = new Campground();
                        c.Id = Convert.ToInt32(reader["campground_id"]);
                        c.ParkId = Convert.ToInt32(reader["park_id"]);
                        c.Name = Convert.ToString(reader["name"]);
                        c.OpenFromMM = Convert.ToInt32(reader["open_from_mm"]);
                        c.OpenToMM = Convert.ToInt32(reader["open_to_mm"]);
                        c.DailyFee = Convert.ToInt32(reader["daily_fee"]);

                        output.Add(c);
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

        public List<Campground> ShowAllCampgroundsInAPark(int park_id)
        {
            List<Campground> output = new List<Campground>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_ShowCampgroundsInAPark, conn);

                    cmd.Parameters.AddWithValue("@park_id", park_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Campground c = new Campground();
                        c.Id = Convert.ToInt32(reader["campground_id"]);
                        c.ParkId = Convert.ToInt32(reader["park_id"]);
                        c.Name = Convert.ToString(reader["name"]);
                        c.OpenFromMM = Convert.ToInt32(reader["open_from_mm"]);
                        c.OpenToMM = Convert.ToInt32(reader["open_to_mm"]);
                        c.DailyFee = Convert.ToInt32(reader["daily_fee"]);

                        output.Add(c);
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
