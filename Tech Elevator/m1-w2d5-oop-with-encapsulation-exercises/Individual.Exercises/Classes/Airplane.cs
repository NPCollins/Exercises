using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        private string planeNumber;
        private int bookedFirstClassSeats;
        private int totalFirstClassSeats;
        private int bookedCoachSeats;
        private int totalCoachSeats;

        public string PlaneNumber
        {
            get { return planeNumber; }
        }

        public int BookedFirstClassSeats
        {
            get { return bookedFirstClassSeats; }
        }

        public int AvailableFirstClassSeats
        {
            get { return TotalFirstClassSeats - BookedFirstClassSeats; }
        }

        public int TotalFirstClassSeats
        {
            get { return totalFirstClassSeats; }
        }

        public int BookedCoachSeats
        {
            get { return bookedCoachSeats; }
        }

        public int AvailableCoachSeats
        {
            get { return TotalCoachSeats - BookedCoachSeats; }
        }

        public int TotalCoachSeats
        {
            get { return totalCoachSeats; }
        }

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.totalFirstClassSeats = totalFirstClassSeats;
            this.totalCoachSeats = totalCoachSeats;
            this.planeNumber = planeNumber;
        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass == true)
            {
                if (AvailableFirstClassSeats >= totalNumberOfSeats)
                {
                    bookedFirstClassSeats += totalNumberOfSeats;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (AvailableCoachSeats >= totalNumberOfSeats)
                {
                    bookedCoachSeats += totalNumberOfSeats;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
