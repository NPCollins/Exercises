using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherWebsite.Models;
using WeatherWebsite.DALs;

namespace WeatherWebsite.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        public ActionResult Weather(string id)
        {
            List<Weather> weather = new WeatherSqlDAL().GetWeather(id);

            string celsius = "";

            if (Request != null)
            {
                celsius = Request.Params["TempUnit"];

                if (celsius != null && celsius != "")
                {
                    if (celsius.Contains("True"))
                    {
                        Session["UnitsC"] = "True";
                    }
                    else
                    {
                        Session["UnitsC"] = "False";
                    }
                }
            }
                

            return View("Weather", weather);
        }
    }
}