using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using VoterInformation.Models;

namespace VoterInformation.DAO
{
    public class VoterDAO
    {
        string connectionString = @"Data Source=DESKTOP-QSBFLBV;Initial Catalog=VoterData;Integrated Security=True";
        string SQL_VotersforStreet = "SELECT FIRSTNAME, LASTNAME, RES_HOUSE, RES_STREET FROM Voter WHERE RES_STREET LIKE CONCAT('%',@streetName,'%') ORDER BY LASTNAME, FIRSTNAME;";


        public List<VoterModel> GetVotersByStreet(string streetName)
        {
            List<VoterModel> result = new List<VoterModel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_VotersforStreet, conn);

                    cmd.Parameters.AddWithValue("@streetName", streetName);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        VoterModel v  = new VoterModel();
                        v.FirstName = Convert.ToString(reader["FIRSTNAME"]);
                        v.LastName  = Convert.ToString(reader["LASTNAME"]);
                        v.StreetNumber = Convert.ToString(reader["RES_HOUSE"]);
                        v.StreetName = Convert.ToString(reader["RES_STREET"]);
                        result.Add(v);
                    }
                }
            }
            catch (SqlException ex)
            {
                //Log and throw the exception
                throw;
            }

            return result;
        }
    }
}