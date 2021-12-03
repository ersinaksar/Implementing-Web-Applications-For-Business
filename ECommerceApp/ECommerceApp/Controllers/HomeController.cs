using ECommerceApp.Models;
using ECommerceApp.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceApp.Controllers
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
            /*ProductBusiness productBusiness = new ProductBusiness(); 
            ViewBag.LatestProduct = productBusiness.GetAll().OrderByDescending(p => p.ProductID).Take(6).ToList();
            */
            var products = new List<Products>
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
                },
                new Products
                {
                    ProductID = 4,
                    ProductName = "Computer",
                    SuplierID = 4,
                    CategoryID =4,
                    UnitPrice = 8000,
                    UnitsInStock = 4
                },

                new Products
                {
                    ProductID = 5,
                    ProductName = "Phone",
                    SuplierID = 5,
                    CategoryID =5,
                    UnitPrice = 4000,
                    UnitsInStock = 20
                },

                new Products
                {
                    ProductID = 6,
                    ProductName = "Tapblet",
                    SuplierID = 6,
                    CategoryID =6,
                    UnitPrice = 6000,
                    UnitsInStock = 10
                }

            };
            ViewBag.LatestProduct = products;
            return View();
        }
    }
}