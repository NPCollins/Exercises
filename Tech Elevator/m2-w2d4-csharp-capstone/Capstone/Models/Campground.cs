using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Capstone.Models
{
    public class Campground
    {
        public int Id { get; set; }
        public int ParkId { get; set; }
        public string Name { get; set; }
        public int OpenToMM { get; set; }
        public int OpenFromMM { get; set; }
        public int DailyFee { get; set; }



        public override string ToString()
        {
            string tempMonthFrom = GetMonth(OpenFromMM);
            string tempMonthTo = GetMonth(OpenToMM);

            return Id.ToString().PadRight(5) + Name.PadRight(45) + tempMonthFrom.ToString().PadRight(20) + tempMonthTo.PadRight(20) + DailyFee.ToString("C");
        }


        /// <summary>
        /// Converts integer value to month name
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        public string GetMonth(int month)
        {
            string monthName = "";

            if(month == 1)
            {
                monthName = "January";
                return monthName;
            }
            if(month == 2)
            {
                monthName = "February";
                return monthName;
            }
            if (month == 3)
            {
                monthName = "March";
                return monthName;
            }
            if (month == 4)
            {
                monthName = "April";
                return monthName;
            }
            if (month == 5)
            {
                monthName = "May";
                return monthName;
            }
            if (month == 6)
            {
                monthName = "June";
                return monthName;
            }
            if (month == 7)
            {
                monthName = "July";
                return monthName;
            }
            if (month == 8)
            {
                monthName = "August";
                return monthName;
            }
            if (month == 9)
            {
                monthName = "September";
                return monthName;
            }
            if (month == 10)
            {
                monthName = "October";
                return monthName;
            }
            if (month == 11)
            {
                monthName = "November";
                return monthName;
            }
            if (month == 12)
            {
                monthName = "December";
                return monthName;
            }
            return monthName;
        }
    }
}
