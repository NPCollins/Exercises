using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Models
{
    public class AlienWeightModel
    {

        public static List<SelectListItem> Planets { get; } = new List<SelectListItem>()
        {
            // Value is in years. 
            // eg. One mars year is .241 times as long as one earth year
            // and one Uranus year is 164.81 times as long as one earth year.
            new SelectListItem() { Text = "Mercury", Value = ".37" },
            new SelectListItem() { Text = "Venus", Value = ".9" },
            new SelectListItem() { Text = "Mars", Value = ".38" },
            new SelectListItem() { Text = "Jupiter", Value = "2.65"  },
            new SelectListItem() { Text = "Saturn", Value = "1.13" },
            new SelectListItem() { Text = "Neptune", Value = "1.43" },
            new SelectListItem() { Text = "Uranus", Value = "1.09" }
        };

        public string GetPlanetName(double selectedValue)
        {
            string planetName = "";
            foreach (SelectListItem Planet in Planets)
            {
                if (double.Parse(Planet.Value) == selectedValue)
                {
                    planetName = Planet.Text;
                }
            }
            return planetName;
        }

    }
}