using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceApp.Controllers
{
    public class CheckoutControllerController : Controller
    {
        // GET: CheckoutController
        public ActionResult AddressAndPayment()
        {
            return View();
        }
    }
}