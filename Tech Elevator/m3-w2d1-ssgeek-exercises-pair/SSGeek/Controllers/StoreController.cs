using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSGeek.DAL;

namespace SSGeek.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
        // Index is the first page you see, it shows all the products

        public ActionResult AlienStore()
        {
            return View("AlienStore", new ProductSqlDAL().GetProducts());
        }
        // Product detail is what's displayed after you select a product

        public ActionResult ShoppingCart()
        {
            return View();
        }
        // Shopping cart displays all of your selected items and their cost. Gives you the ability to check out.

        public ActionResult ProductDetail()
        {
            int productId = int.Parse(RouteData.Values["id"] + Request.Url.Query);
            return View("ProductDetail", new ProductSqlDAL().GetProduct(productId));
        }
    }
}