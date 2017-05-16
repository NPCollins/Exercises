using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capstone.Models;

namespace Capstone.DAL
{
    public class SiteSqlDAL
    {
        private const string SQL_SearchForAvailableSite = "Select TOP 5 site.site_id, site.campground_id, site.site_number, site.max_occupancy, site.accessible, site.max_rv_length, site.utilities, reservation.from_date, reservation.to_date, campground.campground_id, campground.name, campground.daily_fee FROM site JOIN reservation ON reservation.site_id = site.site_id JOIN campground ON campground.campground_id = site.campground_id WHERE site.campground_id = @campground_id;";
        private const string SQL_ShowAllSitesInACampground = "Select TOP 5 site.site_id, site.campground_id, site.site_number, site.max_occupancy, site.accessible, site.max_rv_length, site.utilities, campground.daily_fee FROM site JOIN campground ON campground.campground_id = site.campground_id WHERE site.campground_id = @campground_id;";
        //private const string SQL_SearchAvailableCampsites = "SELECT site.site_number, site.site_id FROM site where site.campground_id = @campground_id and reservation.from_date >= @from_date and reservation.to_date <= @to_date and campground.park_id = @park_id;";
        private string connectionString;

        private List<int> totalFees = new List<int> { 0 };
        private List<string> campNames = new List<string>();
        public List<int> TotalFees
        {
            get { return totalFees; }
        }
        public List<string> CampNames
        {
            get { return campNames; }
        }

        public SiteSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Site> ShowAllSitesInACampground(int campground_id)
        {
            List<Site> output = new List<Site>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_ShowAllSitesInACampground, conn);

                    cmd.Parameters.AddWithValue("@campground_id", campground_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        Campground c = new Campground();
                        c.Id = Convert.ToInt32(reader["campground_id"]);
                        c.DailyFee = Convert.ToInt32(reader["daily_fee"]);

                        Site s = new Site();
                        s.Id = Convert.ToInt32(reader["site_id"]);
                        s.CampgroundId = Convert.ToInt32(reader["campground_id"]);
                        s.SiteNumber = Convert.ToInt32(reader["site_number"]);
                        s.MaxOccupancy = Convert.ToInt32(reader["max_occupancy"]);
                        s.Accessible = Convert.ToByte(reader["accessible"]);
                        s.MaxRvLength = Convert.ToInt32(reader["max_rv_length"]);
                        s.Utilities = Convert.ToByte(reader["utilities"]);

                        output.Add(s);
                        totalFees.Add(c.DailyFee);
                    }
                }
                totalFees.Remove(0);
            }
            catch (SqlException ex)
            {
                //Log and throw the exception
                throw;
            }

            return output;
        }
             
        public List<Site> SearchForAvailableSite(int campground_id, DateTime from_date, DateTime to_date)
        {
            List<Site> output = new List<Site>(); 
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_SearchForAvailableSite, conn);

                    cmd.Parameters.AddWithValue("@campground_id", campground_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        Reservation r = new Reservation();

                        r.FromDate = Convert.ToDateTime(reader["from_date"]);
                        r.ToDate = Convert.ToDateTime(reader["to_date"]);


                        Site s = new Site();
                        s.Id = Convert.ToInt32(reader["site_id"]);
                        s.CampgroundId = Convert.ToInt32(reader["campground_id"]);
                        s.SiteNumber = Convert.ToInt32(reader["site_number"]);
                        s.MaxOccupancy = Convert.ToInt32(reader["max_occupancy"]);
                        s.Accessible = Convert.ToByte(reader["accessible"]);
                        s.MaxRvLength = Convert.ToInt32(reader["max_rv_length"]);
                        s.Utilities = Convert.ToByte(reader["utilities"]);

                        Campground c = new Campground();
                        c.Id = Convert.ToInt32(reader["campground_id"]);
                        c.Name = Convert.ToString(reader["name"]);
                        c.DailyFee = Convert.ToInt32(reader["daily_fee"]);

                        if ((from_date <= r.FromDate && to_date >= r.FromDate) || (r.ToDate >= from_date && to_date >= r.ToDate))
                        {
                            continue;
                        }
                        else if (r.FromDate <= from_date && r.ToDate >= to_date)
                        {
                            continue;
                        }
                        else
                        {
                            totalFees.Add(c.DailyFee);
                            campNames.Add(c.Name);
                            output.Add(s);
                        }
                    }
                    totalFees.Remove(0);
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
