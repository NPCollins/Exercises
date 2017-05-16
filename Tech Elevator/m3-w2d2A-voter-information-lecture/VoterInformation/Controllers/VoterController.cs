using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VoterInformation.DAO;
using VoterInformation.Models;

namespace VoterInformation.Controllers
{
    public class VoterController : Controller
    {


        // GET: /Voter/Query
        public ActionResult Query()
        {
            return View();
        }

        // GET: ?voter/Lookup
        public ActionResult Lookup()
        {

            string streetName = Request.Params["Street"];

            if (streetName == null || streetName == string.Empty)
            {
                return View("Query");
            }

            VoterDAO thisDAO = new VoterDAO();
            List<VoterModel> voters = thisDAO.GetVotersByStreet(streetName);

            return View(voters);
        }
    }
}