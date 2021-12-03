using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECommerceApp.Models;

namespace ECommerceApp.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}
