using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceApp.Controllers
{
    public class ShoppingCartControllerController : Controller
    {
        // GET: ShoppingCartController
        public ActionResult Index()
        {
            return View();
        }
    }
}