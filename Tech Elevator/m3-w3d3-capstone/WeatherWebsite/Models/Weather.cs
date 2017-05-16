using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherWebsite.Models
{
    public class Weather
    {
        public string ParkCode { get; set; }
        public int FiveDayForecastValue { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
        public string Forecast { get; set; }
        public string Advice { get; set; }


        public string getAdvice(string forecast, double highTemp, double lowTemp)
        {
            string advice = "";
            if (forecast == "sunny")
            {
                advice = "Make sure you pack sunblock. ";
            }
            else if (forecast == "rain")
            {
                advice = "Make sure you pack an umbrella. ";
            }
            else if (forecast == "snow")
            {
                advice = "Make sure you pack your snowshoes. ";
            }
            else if (forecast == "thunderstorms")
            {
                advice = "Seek shelter and avoid hiking on exposed ridges. ";
            }
            if(highTemp > 75)
            {
                advice += "Bring an extra gallon of water. ";
            }
            if((highTemp - lowTemp) > 20)
            {
                advice += "Wear breathable layers. ";
            }
            if (lowTemp < 20)
            {
                advice += "Temperature may fall to dangerously low. Make sure to limit exposed skin. ";
            }
            return advice;
        }

    }

    
}