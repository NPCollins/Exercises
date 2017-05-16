using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherWebsite.Models;
using WeatherWebsite.DALs;

namespace WeatherWebsite.Controllers
{
    public class SurveyController : Controller
    {
        // GET: Survey
        public ActionResult Survey()
        {
            List<Park> parks = new ParkSqlDAL().GetParkHome();
            Dictionary<string, string> parkNames = new Dictionary<string, string>();
            foreach(Park park in parks)
            {
                parkNames.Add(park.ParkName, park.ParkCode);
            }
            return View("Survey",parkNames);
        }

        public ActionResult UpdateSurveyTable()
        {
            if(Request != null)
            {
                Survey survey = new Survey();
                survey.ParkCode = Request.Params["ParkName"];
                survey.EmailAddress = Request.Params["EmailAddress"];
                survey.State = Request.Params["State"];
                survey.ActivityLevel = Request.Params["ActivityLevel"];
                SurveySQLDAL DAL = new SurveySQLDAL();
                DAL.SubmitSurvey(survey);
            }
            return View("Ranking");
        }

        public ActionResult Ranking()
        {
            return View();
        }
    }
}