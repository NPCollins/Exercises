using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Models
{
    public class AlienTravelModel
    {
        public static List<SelectListItem> Planets { get; } = new List<SelectListItem>()
        {
            // Value is in years. 
            // eg. One mars year is .241 times as long as one earth year
            // and one Uranus year is 164.81 times as long as one earth year.
            new SelectListItem() { Text = "Mercury", Value = "56974146" },
            new SelectListItem() { Text = "Venus", Value = "25724767" },
            new SelectListItem() { Text = "Mars", Value = "48678219" },
            new SelectListItem() { Text = "Jupiter", Value = "390674710"  },
            new SelectListItem() { Text = "Saturn", Value = "792248270" },
            new SelectListItem() { Text = "Neptune", Value = "2703959960" },
            new SelectListItem() { Text = "Uranus", Value = "1692662530" }
        };

        public static List<SelectListItem> MethodOfTravel { get; } = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Walking", Value = "3" },
            new SelectListItem() { Text = "Car", Value = "100" },
            new SelectListItem() { Text = "Bullet Train", Value = "200" },
            new SelectListItem() { Text = "Boeing 747", Value = "570"  },
            new SelectListItem() { Text = "Concord", Value = "1350" }
        };

        public string GetPlanetName(long distance)
        {
            string planetName = "";
            foreach (SelectListItem Planet in Planets)
            {
                if (long.Parse(Planet.Value) == distance)
                {
                    planetName = Planet.Text;
                }
            }
            return planetName;
        }


        public string GetTravelMethod(int speed)
        {
            string travelMethod = "";
            foreach (SelectListItem method in MethodOfTravel)
            {
                if (int.Parse(method.Value) == speed)
                {
                    travelMethod = method.Text;
                }
            }
            return travelMethod;
        }

    }
}