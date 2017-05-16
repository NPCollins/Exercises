using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeatherWebsite.Models;
using System.Data.SqlClient;

namespace WeatherWebsite.DALs
{
    public class ParkSqlDAL
    {
        private string connectionString = @"Data Source=DESKTOP-CTIJ0GB\SQLEXPRESS;Initial Catalog=NationalParks;Integrated Security=True";
        private string SQL_For_GetAllParks = "SELECT * FROM park;";
        private string SQL_For_GetPark = "SELECT * FROM park WHERE parkCode = @parkCode;";
        public Park GetParkDetail(string id)
        {
            Park result = new Park();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SQL_For_GetPark, connection);
                    cmd.Parameters.AddWithValue("@parkCode", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Park p = new Park();
                        p.ParkCode = reader["parkCode"].ToString();
                        p.ParkName = reader["parkName"].ToString();
                        p.State = reader["state"].ToString();
                        p.Acreage = int.Parse(reader["acreage"].ToString());
                        p.ElevationInFeet = int.Parse(reader["elevationInFeet"].ToString());
                        p.MilesOfTrail = float.Parse(reader["milesOfTrail"].ToString());
                        p.NumberOfCampsites = int.Parse(reader["numberOfCampsites"].ToString());
                        p.Climate = reader["climate"].ToString();
                        p.YearFounded = int.Parse(reader["yearFounded"].ToString());
                        p.AnnualVisitorCount = int.Parse(reader["annualVisitorCount"].ToString());
                        p.InspirationalQuote = reader["inspirationalQuote"].ToString();
                        p.InspirationalQuoteSource = reader["inspirationalQuoteSource"].ToString();
                        p.ParkDescription = reader["parkDescription"].ToString();
                        p.EntryFee = int.Parse(reader["entryFee"].ToString());
                        p.NumberOfAnimalSpecies = int.Parse(reader["numberOfAnimalSpecies"].ToString());
                        result=p;
                    }
                }
                return result;
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
        public List<Park> GetParkHome()
        {
            List<Park> result = new List<Park>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SQL_For_GetAllParks, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Park p = new Park();
                        p.ParkCode = reader["parkCode"].ToString();
                        p.ParkName = reader["parkName"].ToString();
                        p.State = reader["state"].ToString();
                        p.ParkDescription = reader["parkDescription"].ToString();
                        result.Add(p);
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