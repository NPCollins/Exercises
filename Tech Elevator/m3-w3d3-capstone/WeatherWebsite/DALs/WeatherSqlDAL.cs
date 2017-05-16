using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeatherWebsite.Models;
using System.Data.SqlClient;
namespace WeatherWebsite.DALs
{
    public class WeatherSqlDAL
    {
        private string connectionString = @"Data Source=DESKTOP-CTIJ0GB\SQLEXPRESS;Initial Catalog=NationalParks;Integrated Security=True";
        private string GetWeather_SQL = "SELECT * FROM weather WHERE parkCode = @ParkCode;";

        public List<Weather> GetWeather(string parkID)
        {
            try
            {
                List<Weather> result = new List<Weather>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(GetWeather_SQL);
                    cmd.Parameters.AddWithValue("@ParkCode", parkID);
                    cmd.Connection = connection;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Weather w = new Weather();
                        w.ParkCode = reader["parkCode"].ToString();
                        w.FiveDayForecastValue = int.Parse(reader["fiveDayForecastValue"].ToString());
                        w.Low = int.Parse(reader["low"].ToString());
                        w.High = int.Parse(reader["high"].ToString());
                        w.Forecast = reader["forecast"].ToString();
                        result.Add(w);
                    }
                }
                return result;
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}