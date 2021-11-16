using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            //return "Hello from Store.Index()";  
            var genres = new List<Genre>
            {
                new Genre { Name = "Disco"},
                new Genre { Name = "Jazz"},
                new Genre { Name = "Rock"}
            };
            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            //string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }

        public ActionResult Details(int id)
        {
            //string message = "Store.Details, ID = " + id;
            var album = new Album {  Title = "Album " + id };
            return View(album);
        }
    }
}