using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "com",
                    Price = 12000,
                    Stock = 1500,
                },
                new Product
                {
                    Id = 2,
                    Name = "com2",
                    Price = 12000,
                    Stock = 1500,
                }
            };


            
            //Product product1 = new Product();
            //product1.Id = 1;
            //product1.Name = "computer";
            //product1.Price = 54900;
            //product1.Stock = 12;
            //products.Add(product1);
            return View(products);
        }
    }
}