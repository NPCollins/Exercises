using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult XOrdered()
        {
            return View();
        }

        public ActionResult XOrderedResult()
        {
            Person tempPerson = new Models.Person(Request.Params["FirstName"], Request.Params["LastName"], Request.Params["Initial"], Request.Params["order"]);
            return View("XOrderedResult", tempPerson);
        }

        public ActionResult Colorize()
        {
            return View();
        }
        public ActionResult ColorizeResults()
        {
            Person tempPerson = new Models.Person(Request.Params["FirstName"], Request.Params["LastName"], Request.Params["Red"], Request.Params["Green"], Request.Params["Blue"]);

            return View("ColorizeResults", tempPerson);
        }

        public ActionResult FizzBuzz()
        {
            return View();
        }

        public ActionResult FizzBuzzResults()
        {
            FizzBuzz tempFizzBuzz = new Models.FizzBuzz();
            tempFizzBuzz.Divisor1 = int.Parse(Request.Params["Divisor1"]);
            tempFizzBuzz.Divisor2 = int.Parse(Request.Params["Divisor2"]);
            tempFizzBuzz.NumberList.Add(int.Parse(Request.Params["Number1"]));
            tempFizzBuzz.NumberList.Add(int.Parse(Request.Params["Number2"]));
            tempFizzBuzz.NumberList.Add(int.Parse(Request.Params["Number3"]));
            tempFizzBuzz.NumberList.Add(int.Parse(Request.Params["Number4"]));
            tempFizzBuzz.NumberList.Add(int.Parse(Request.Params["Number5"]));
            tempFizzBuzz.AltFizz = Request.Params["AltFizz"];
            tempFizzBuzz.AltBuzz = Request.Params["AltBuzz"];

            return View("FizzBuzzResults", tempFizzBuzz);
        }
    }
}