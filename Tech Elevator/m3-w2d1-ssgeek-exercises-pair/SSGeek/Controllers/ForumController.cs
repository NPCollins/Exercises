using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSGeek.DAL;
using SSGeek.Models;

namespace SSGeek.Controllers
{
    public class ForumController : Controller
    {

        // GET: Forum
        public ActionResult AlienForum()
        {

            ForumPost curruForumPost = new ForumPost();
            curruForumPost.Subject = Request.Params["Subject"];
            curruForumPost.Username = Request.Params["Username"];
            curruForumPost.Message = Request.Params["Message"];


            if (!new ForumPostSqlDAL().SaveNewPost(curruForumPost))
            {
                return View("AlienForum");
            }
            else
            {

                return View("AlienForum", new ForumPostSqlDAL().GetAllPosts());
            }
        }
        // GET: Forum/ForumSubmit
        public ActionResult AlienForumSubmit()
        {

            return View();
        }
    }
}