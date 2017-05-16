using FlyByNightBank.Web.DAL;
using FlyByNightBank.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyByNightBank.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserDAL userDal;
        public UserController(IUserDAL userDal)
        {
            this.userDal = userDal;
        }


        // GET: User/Register
        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public ActionResult Register(User model)
        {
            if(model.FirstName == model.LastName && !String.IsNullOrEmpty(model.FirstName))
            {
                ModelState.AddModelError("SameFirstLast", "Your first name cant be the same as your last name");
            }

            if (!ModelState.IsValid)
            {
                return View("Register", model);
            }

            this.userDal.SaveUser(model);
            return RedirectToAction("Index", "Home");
        }

    }
}