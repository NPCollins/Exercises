using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    class FexEd : IDeliveryDriver
    {


        public double CalculateRate(int distance, double weight)
        {
            double rate = 20.0;
            if (distance > 500)
            {
                rate += 5;
            }
            if (weight > 48)
            {
                rate += 3;
            }
            return rate;
        }
    }
}
