using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherWebsite.DALs;
using WeatherWebsite.Models;

namespace WeatherWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Park> parks = new ParkSqlDAL().GetParkHome();
            
            
            return View("Index",parks);
        }

        public ActionResult Detail(string id)
        {
            Park park = new ParkSqlDAL().GetParkDetail(id);

            return View("Detail", park);
        }
    }
}