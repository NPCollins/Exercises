using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET /Home/About/
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Browser = Url.RequestContext.HttpContext.Request.UserAgent;

            return View();
        }

        // GET /Home/Contact/
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET /Home/Helpers/
        public ActionResult Helpers()
        {
            ViewBag.Message = "Helper page.";
            Person person = GetPerson();
            return View(person);
        }

        // GET /Home/HelpersPRG/
        public ActionResult HelpersPRG()
        {
            ViewBag.Message = "HelpersPRG page.";
            Person person = GetPerson();
            return View(person);
        }

        // GET /Home/HelpersCompletePRG/
        public ActionResult HelpersCompletePRG()
        {
            ViewBag.Message = "HelpersCompletePRG page.";
           
            return View();
        }

        // POST /Home/HelpersUpdate
        [HttpPost]
        public ActionResult HelpersUpdate()
        {
            ViewBag.Message = "Helper page.";
            Person person = new Models.Person();
            person.FirstName = Request.Params["First"];
            person.LastName = Request.Params["Last"];

            if (Request["Driver"] != null)
            {
                string result = Request["Driver"];
                if (result.Contains("true"))
                {
                    person.LicensedDriver = true;
                }
            }

            if (Request["FavoriteColor"] != null)
            {
                string result = Request["FavoriteColor"];
                person.FavoriteColor = result;
            }
            else
            {
                person.FavoriteColor = "Red";
            }

            person.BirthYear = int.Parse(Request.Params["Birth"]);

            person.ResidenceState = Request.Params["ResidenceState"];

            return View("Helpers", person);
        }


        // POST /Home/HelpersUpdatePRG
        [HttpPost]
        public ActionResult HelpersUpdatePRG()
        {
            ViewBag.Message = "Helper page.";
            Person person = new Models.Person();
            person.FirstName = Request.Params["First"];
            person.LastName = Request.Params["Last"];

            if (Request["Driver"] != null)
            {
                string result = Request["Driver"];
                if (result.Contains("true"))
                {
                    person.LicensedDriver = true;
                }
            }

            if (Request["FavoriteColor"] != null)
            {
                string result = Request["FavoriteColor"];
                person.FavoriteColor = result;
            }
            else
            {
                person.FavoriteColor = "Red";
            }

            person.BirthYear = int.Parse(Request.Params["Birth"]);

            person.ResidenceState = Request.Params["ResidenceState"];


            //here
            if (ModelState.IsValid)
            {
                return RedirectToAction("HelpersCompletePRG");
            }
            
            return View("HelpersPRG", person);
        }


        // GET Home/Input/
        [HttpGet]
        public ActionResult Input()
        {
            string name;

            if ((Request.Params["fname_name"] == null) || (Request.Params["fname_name"] == null))
            {
                name = "";
            }
            else
            {
                name = Request.Params["fname_name"] + " " + Request.Params["lname_name"];
            }
            ViewBag.Name = name;

            return View();
        }

        // POST /Home/InputResponse/
        [HttpPost]
        public ActionResult InputResponse()
        {
            string name;

            if ((Request.Params["fname_name"] == null) || (Request.Params["fname_name"] == null))
            {
                name = "";
            }
            else
            {
                name = Request.Params["fname_name"] + " " + Request.Params["lname_name"];
            }
            ViewBag.Name = name;

            return View("Input");
        }


        private Person GetPerson()
        {
            Person p1 = new Models.Person();
            p1.FirstName = "John";
            p1.LastName = "Fulton";
            p1.BirthYear = 1953;
            p1.LicensedDriver = true;
            p1.FavoriteColor = "Blue";
            p1.ResidenceState = "Ohio";

            return p1;
        }
    }
}