using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeatherWebsite.Models;
using System.Data.SqlClient;

namespace WeatherWebsite.DALs
{
    public class SurveySQLDAL
    {
        private string connectionString = @"Data Source=DESKTOP-CTIJ0GB\SQLEXPRESS;Initial Catalog=NationalParks;Integrated Security=True";
        private string EnterSurveyData_SQL = "INSERT INTO survey_result VALUES (@parkCode, @emailAddress, @state, @activityLevel)";
        private string GetRanking_SQL = "SELECT TOP 5 parkName, COUNT(parkName) as votes FROM survey_result JOIN park ON park.parkCode = survey_result.parkCode GROUP BY parkName ORDER BY votes DESC;";

        public bool SubmitSurvey(Survey survey)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(EnterSurveyData_SQL, connection);
                    cmd.Parameters.AddWithValue("@parkCode", survey.ParkCode);
                    cmd.Parameters.AddWithValue("@emailAddress", survey.EmailAddress);
                    cmd.Parameters.AddWithValue("@state", survey.State);
                    cmd.Parameters.AddWithValue("@activityLevel", survey.ActivityLevel);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
        public List<SurveyResult> GetRanking()
        {
            List<SurveyResult> result = new List<SurveyResult>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(GetRanking_SQL, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        SurveyResult s = new SurveyResult();
                        s.ParkName = reader["parkName"].ToString();
                        s.NumberOfVotes = int.Parse(reader["votes"].ToString());
                        result.Add(s);

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