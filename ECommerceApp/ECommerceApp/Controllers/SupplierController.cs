using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceApp.Controllers
{
    public class SupplierController : Controller
    {
        // GET: Supplier
        public ActionResult SupplierMenu()
        {
            return View();
        }
    }
}