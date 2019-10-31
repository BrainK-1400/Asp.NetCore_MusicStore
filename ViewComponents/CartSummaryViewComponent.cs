using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public CartSummaryViewComponent(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            return View(_shoppingCart);
        }
    }
}
