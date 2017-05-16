using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace WebApplication3.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public bool LicensedDriver { get; set; }
        public string FavoriteColor { get; set; }
        public string ResidenceState { get; set; }

        public override string ToString()
        {
            return (FirstName.PadRight(20) + LastName.PadRight(20)
                + LicensedDriver.ToString().PadRight(20) + BirthYear.ToString().PadRight(20)
                + FavoriteColor.ToString().PadRight(20) + ResidenceState.ToString().PadRight(20));
        }

        public static List<SelectListItem> GetStates()
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem
            {
                Text = "Ohio",
                Value = "Ohio"
            });
            listItems.Add(new SelectListItem
            {
                Text = "Michigan",
                Value = "Michigan",
            });
            listItems.Add(new SelectListItem
            {
                Text = "Pennsylvania",
                Value = "Pennsylvania"
            });
            listItems.Add(new SelectListItem
            {
                Text = "Indiana",
                Value = "Indiana"
            });
            listItems.Add(new SelectListItem
            {
                Text = "Kentucky",
                Value = "Kentucky"
            });

            return listItems;

        }
    }
}