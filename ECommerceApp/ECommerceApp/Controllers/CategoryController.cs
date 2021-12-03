using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult CategoryMenu()
        {
            return View();
        }

        public int ProductsByCategory { get; set; }
    }
}