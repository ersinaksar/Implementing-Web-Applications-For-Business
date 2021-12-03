using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceApp.Repository.Concrete;

namespace ECommerceApp.Controllers
{
    public class CategoryController : Controller
    {
        CategoryBusiness categoryBusiness = new CategoryBusiness();

        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            return View(categoryBusiness.GetAll());
        }

        public int ProductsByCategory { get; set; }
    }
}