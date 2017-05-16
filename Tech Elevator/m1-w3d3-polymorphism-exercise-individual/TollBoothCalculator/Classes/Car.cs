using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehicle
    {
        private bool hasTrailer;
        public bool HasTrailer
        {
            get { return hasTrailer; }
        }

        public Car(bool hasTrailer)
        {
            this.hasTrailer = hasTrailer;
        }

        public double CalculateToll(int distance)
        {
            double toll = distance * 0.020;
            if (hasTrailer == true)
            {
                toll += 1;
            }
            return toll;
        }
    }
}
