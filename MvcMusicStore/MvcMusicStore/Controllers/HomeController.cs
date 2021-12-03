using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            /*
             * collection ya da array lazım çünkü  arayüze multiple product göndermek istiyoruz 
             * bunları tutacak yapımız bunlar
            */


            //var products = new List<Products>();//our generic lists
            //products.Add() //adding new products this lcollection 
            /*var products = new List<Products>//Generic list product
            {
                new Products
                {
                    ProductID = 1,
                    ProductName = "Computer",
                    SuplierID = 1,
                    CategoryID =1,
                    UnitPrice = 8000,
                    UnitsInStock = 5
                },

                new Products
                {
                    ProductID = 2,
                    ProductName = "Phone",
                    SuplierID = 2,
                    CategoryID =2,
                    UnitPrice = 4000,
                    UnitsInStock = 20
                },

                new Products
                {
                    ProductID = 3,
                    ProductName = "Tapblet",
                    SuplierID = 3,
                    CategoryID =3,
                    UnitPrice = 6000,
                    UnitsInStock = 10
                }

            };
            return View(products);
            */
            
            return View();
        }
    }
}


