using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewsPart2.Web.Models;

namespace ViewsPart2.Web.Controllers
{
    /*
    * Each Controller Action below responds to a request from a browser.
    * If the user visits http://localhost/Home/Index then the
    * Index Action will execute, returning the Index view.
    */
    public class HomeController : Controller
    {

        // GET: Home/Index
        // GET: Home/
        // GET: /
        public ActionResult Index()
        {
            // This does nothing, but shows the request context
            object thisRequest = Url.RequestContext;

            // Controllers normally get the model from a database or another part of the code base.

            // A model is a class that we want to display in a view.            
            Person person = new Person
            {
                FirstName = "Nicholas",
                LastName = "Collins",
                Hometown = "Columbus",
                Interests = new List<string>()
                {
                    "C#",
                    "EVE Online",
                    "Playing Guitar",
                    "C#",
                    "C#",                    
                }
            };
            // We can try passing a different model in
            // and see how the page changes


            // Return the View "Index" and pass the model person
            return View("Index", person);
        }


        // GET: Home/Colors
        public ActionResult Colors()
        {
            List<string> colorList = new List<string>()
            {
                "Red",
                "Blue",
                "Orange",
                "Green"
            };

            // Return the View "Colors" and pass the colorList as the model
            return View("Colors", colorList);
        }

        // GET: Home/Team
        public ActionResult Team()
        {
            // Again normally the controller will get this data from another method or class
            List<Person> team = new List<Person>()
            {
                new Person { FirstName = "Luke", LastName = "Skywalker", Hometown = "Tatooine" },
                new Person { FirstName = "Anakin", LastName = "Skywalker", Hometown = "Tatooine"},
                new Person { FirstName = "Rey", LastName = "?", Hometown = "Jakku" }
            };

            // Return the View "Team" and pass the team (List<Person>) as the model
            return View("Team", team);
        }
    }
}