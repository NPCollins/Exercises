using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    class SPU : IDeliveryDriver
    {
        private string shippingType;
        public string ShippingType
        {
            get { return shippingType; }
            set { shippingType = value; }
        }   
        public double CalculateRate(int distance, double weight)
        {

            double rate = 0;
            if (shippingType == "fd")
            {
                rate = (weight * 0.0050) * distance;
            }
            else if (shippingType == "td")
            {
                rate = (weight * 0.050) * distance;
            }
            else if (shippingType == "nd")
            {
                rate = (weight * 0.075) * distance;
            }
            return rate;
        }
    }
}
