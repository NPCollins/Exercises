using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capstone.Models;

namespace Capstone.DAL
{
    public class ReservationSqlDAL
    {

        private const string SQL_SearchForAReservation = "Select reservation.site_id, reservation.name, reservation.from_date, reservation.to_date, reservation.create_date FROM reservation JOIN site ON reservation.site_id = site.site_id JOIN campground ON campground.campground_id = site.campground_id WHERE site.campground_id = @campground_id;";
        //private const string SQL_SearchAvailableCampsites = "SELECT site.site_number, site.site_id FROM site where site.campground_id = @campground_id and reservation.from_date >= @from_date and reservation.to_date <= @to_date and campground.park_id = @park_id;";
        private const string SQL_MakeReservation = "INSERT INTO reservation(site_id, name, from_date, to_date) VALUES (@site_id, @name, @from_date, @to_date);";
        private const string SQL_GetReservation_Id = "SELECT max(reservation_id) from reservation;";
        private const string SQL_GetUpcomingReservations = "SELECT reservation.reservation_id, reservation.site_id, reservation.name, reservation.from_date, reservation.to_date, reservation.create_date FROM reservation JOIN site ON reservation.site_id = site.site_id JOIN campground ON site.campground_id = campground.campground_id JOIN park ON campground.park_id = park.park_id WHERE park.park_id= @park_id and from_date between getdate() and getdate()+30;";
        private const string SQL_GetFullReservationInfo = "SELECT TOP 1 * FROM reservation ORDER BY reservation_id DESC;";

        private string connectionString;

        public ReservationSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Reservation> SearchForAReservation(int campground_id, DateTime from_date, DateTime to_date)
        {
            List<Reservation> output = new List<Reservation>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_SearchForAReservation, conn);

                    cmd.Parameters.AddWithValue("@campground_id", campground_id);
                    cmd.Parameters.AddWithValue("@from_date", from_date);
                    cmd.Parameters.AddWithValue("@to_date", to_date);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        Reservation r = new Reservation();
                        r.Id = Convert.ToInt32(reader["reservation_id"]);
                        r.SiteId = Convert.ToInt32(reader["site_id"]);
                        r.Name= Convert.ToString(reader["name"]);
                        r.FromDate = Convert.ToDateTime(reader["from_date"]);
                        r.ToDate = Convert.ToDateTime(reader["to_date"]);
                        r.CreateDate = Convert.ToDateTime(reader["create_date"]);

                        if (( from_date <= r.FromDate && to_date >= r.FromDate ) || (r.ToDate >= from_date && to_date >= r.ToDate))
                        {
                            continue;
                        }
                        else if(r.FromDate <= from_date && r.ToDate >= to_date)
                        {
                            continue;
                        }
                        else
                        {
                            output.Add(r);
                        }
                            
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

        public bool MakeReservation(Reservation newReservation)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_MakeReservation, conn);

                    cmd.Parameters.AddWithValue("@site_id", newReservation.SiteId);
                    cmd.Parameters.AddWithValue("@name", newReservation.Name);
                    cmd.Parameters.AddWithValue("@from_date", newReservation.FromDate);
                    cmd.Parameters.AddWithValue("@to_date", newReservation.ToDate);

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

        public List<Reservation> GetFullReservationInfo()
        {
            List<Reservation> output = new List<Reservation>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetFullReservationInfo, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Reservation r = new Reservation();
                        r.Id = Convert.ToInt32(reader["reservation_id"]);
                        r.SiteId = Convert.ToInt32(reader["site_id"]);
                        r.Name = Convert.ToString(reader["name"]);
                        r.FromDate = Convert.ToDateTime(reader["from_date"]);
                        r.ToDate = Convert.ToDateTime(reader["to_date"]);
                        r.CreateDate = Convert.ToDateTime(reader["create_date"]);

                        output.Add(r);
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

        public int GetReservation_Id()
        {
            int output;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetReservation_Id, conn);

                    int reservationIdReturned = (int)cmd.ExecuteScalar();
                    output = reservationIdReturned;
                }
            }
            catch (SqlException ex)
            {
                //Log and throw the exception
                throw;
            }

            return output;
        }

        public List<Reservation> GetUpcomingReservations(int park_id)
        {
            List<Reservation> output = new List<Reservation>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetUpcomingReservations, conn);

                    cmd.Parameters.AddWithValue("@park_id", park_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Reservation r = new Reservation();
                        r.Id = Convert.ToInt32(reader["reservation_id"]);
                        r.SiteId = Convert.ToInt32(reader["site_id"]);
                        r.Name = Convert.ToString(reader["name"]);
                        r.FromDate = Convert.ToDateTime(reader["from_date"]);
                        r.ToDate = Convert.ToDateTime(reader["to_date"]);
                        r.CreateDate = Convert.ToDateTime(reader["create_date"]);

                        output.Add(r);
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
