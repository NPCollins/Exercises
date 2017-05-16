using SSGeek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Controllers
{
    public class CalculatorsController : Controller
    {
        // INSTRUCTIONS
        // As a part of each exercise you will need to 
        // - develop a view for AlienAge, AlienWeight, and AlienTravel that displays a form to submit data
        // - develop a model for the forms to bind to when the form request is submitted
        // - create a new action to process the form submission (e.g. AlienAgeResult, AlienWeightResult, etc.)
        // - create a view that displays the submitted form result

        // GET: Calculators/AlienAge
        public ActionResult AlienAge()
        {
            return View("AlienAge");
        }

        public ActionResult AlienAgeResult(AlienAgeModel model)
        {
            
            double planetYears  =  double.Parse(Request.Params["PlanetAge"]);
            int age = int.Parse(Request.Params["ClientAge"]);
            string planetName = model.GetPlanetName(planetYears);
            double planetAge = age / planetYears;
            ViewBag.PlanetAge = planetAge;
            ViewBag.PlanetName = planetName;

            return View("AlienAgeResult", model);
        }

        //TODO: Create an AlienWeight and AlienWeightResult Action

        public ActionResult AlienWeight()
        {
            return View("AlienWeight");
        }

        public ActionResult AlienWeightResult(AlienWeightModel model)
        {

            double planetGravity = double.Parse(Request.Params["PlanetGravity"]);
            double weight = double.Parse(Request.Params["ClientWeight"]);
            string planetName = model.GetPlanetName(planetGravity);
            double planetWeight = weight * planetGravity;
            ViewBag.planetWeight = planetWeight;
            ViewBag.planetName = planetName;
            ViewBag.earthWeight = weight;

            return View("AlienWeightResult", model);
        }

        //TODO: Create an AlienTravel and AlienTravelResult Action

        public ActionResult AlienTravel()
        {
            return View("AlienTravel");
        }

        public ActionResult AlienTravelResult(AlienTravelModel model)
        {

            long planetDistance = long.Parse(Request.Params["PlanetDistance"]);
            int age = int.Parse(Request.Params["ClientAge"]);
            int speed = int.Parse(Request.Params["MethodOfTravel"]);
            double time = (planetDistance / speed) / (24 * 365);
            string methodName = model.GetTravelMethod(speed);
            string planetName = model.GetPlanetName(planetDistance);

            ViewBag.time = time;
            ViewBag.newAge = time + age;
            ViewBag.methodName = methodName;
            ViewBag.planetName = planetName;


            return View("AlienTravelResult", model);
        }

        
        



        private List<SelectListItem> transportationModes = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Walking", Value="walking" },
            new SelectListItem() { Text = "Car", Value = "car" },
            new SelectListItem() { Text = "Bullet Train", Value = "bullet train" },
            new SelectListItem() { Text = "Boeing 747", Value = "boeing 747" },
            new SelectListItem() { Text = "Concorde", Value = "concorde" }
        };
    }
}