using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CountInSession();

            return View();
        }

        public ActionResult Input()
        {
            CountInSession();

            //System.Collections.Specialized.NameValueCollection parameters = Url.RequestContext.HttpContext.Request.Params;

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

        public ActionResult Search()
        {
            //System.Collections.Specialized.NameValueCollection parameters = Url.RequestContext.HttpContext.Request.Params;

            CountInSession();

            string response;

            if (Request.Params["q"] == null) 
            {
                response = "";
            }
            else if (Request.Params["q"].ToLower() == "john")
            {
                response = "John Fulton";
            }
            else if (Request.Params["q"].ToLower() == "lisa")
            {
                response = "Lisa Bruegge-Fulton";
            }
            else 
            {
                response = "some other person";
            }
            ViewBag.Response = response;

            return View();
        }


        public ActionResult About()
        {
            CountInSession();

            ViewBag.Message = "Your application description page.";
            ViewBag.Browser = Url.RequestContext.HttpContext.Request.UserAgent;

            return View();
        }

        public ActionResult Contact()
        {
            CountInSession();

            ViewBag.Message = "Your contact page.";

            return View();
        }

        private void CountInSession()
        {
            if (Session["PageCounter"] != null)
            {
                int tempValue = (int)Session["PageCounter"];
                tempValue++;
                Session["PageCounter"] = tempValue;
            }
            else
            {
                Session["PageCounter"] = 1;
            }
        }
    }
}