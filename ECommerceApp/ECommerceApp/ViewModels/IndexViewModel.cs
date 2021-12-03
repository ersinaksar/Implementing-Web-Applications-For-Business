using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECommerceApp.Models;

namespace ECommerceApp.ViewModels
{
    public class IndexViewModel
    {
        public List<Product> LatestProducts { get; set; }
        public List<Product> RecommendedProducts { get; set; }
    }
}
