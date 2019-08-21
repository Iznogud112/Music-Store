using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> ListCart { get; set; }
        public decimal CartTotal { get; set; }
    }
}