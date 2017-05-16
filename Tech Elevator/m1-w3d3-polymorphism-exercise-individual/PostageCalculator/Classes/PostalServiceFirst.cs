using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    class PostalServiceFirst : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;
            if (weight >= 0 && weight <= 2)
            {
                rate = distance * .035;
            }
            else if (weight >= 3 && weight <= 8)
            {
                rate = distance * .040;
            }
            else if (weight >= 9 && weight <= 15)
            {
                rate = distance * .047;
            }
            else if (weight >= 16 && weight <= 48)
            {
                rate = distance * .195;
            }
            else if (weight >= 64 && weight <= 128)
            {
                rate = distance * .450;
            }
            else if (weight >= 144)
            {
                rate = distance * .500;
            }
            return rate;
        }
    }
}
