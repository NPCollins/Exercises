using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
        private int numberOfAxles;
        public int NumberOfAxles
        {
            get { return numberOfAxles; }
        }

        public Truck(int numberOfAxles)
        {
            this.numberOfAxles = numberOfAxles;
        }

        public double CalculateToll(int distance)
        {
            if (numberOfAxles == 4)
            {
                double toll = .040 * distance;
                return toll;
            }
            else if (numberOfAxles == 6)
            {
                double toll = .045 * distance;
                return toll;
            }
            else
            {
                double toll = .048 * distance;
                return toll;
            }

        }
    }
}
