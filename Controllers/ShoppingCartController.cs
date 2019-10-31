using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Extensions;
using MusicStore.Models;
using MusicStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Text.Encodings.Web;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MusicStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly MyContext _myContext;
        private readonly ShoppingCart _cartService;

        public ShoppingCartController(MyContext myContext,ShoppingCart cartService)
        {
            _myContext = myContext;
            _cartService = cartService;
        }

        //
        //
        // old
        //
        //

        //[HttpGet]
        //public async Task<IActionResult> Index()
        //{
        //    var cart = ShoppingCart.GetCart(this.HttpContext);
        //    var viewModel = new ShoppingCartViewModel
        //    {
        //        CartItems = await cart.GetCartItems(),
        //        CartTotal = await cart.GetTotal()
        //    };
        //    return View(viewModel);
        //}
        //[HttpGet]
        //public async Task<IActionResult> AddToCart(int id)
        //{
        //    var addedAlbum =await _myContext.Albums.SingleAsync(album=>album.AlbumId==id);
        //    var cart = ShoppingCart.GetCart(this.HttpContext);
        //    await cart.AddToCart(addedAlbum);
        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        //public async Task<IActionResult> RemoveFromCart(int id)
        //{
        //    var cart = ShoppingCart.GetCart(this.HttpContext);
        //    string albumName =  _myContext.Carts.Single(item => item.RecordId == id).Album.Title;
        //    int itemCount =await cart.RemoveFromCart(id);

        //    var results = new ShoppingCartRemoveViewModel
        //    {
        //        Message = HttpUtility.HtmlEncode(albumName) + " has been removed from your shopping cart.",
        //        CartTotal = await cart.GetTotal(),
        //        CartCount = await cart.GetCount(),
        //        DeleteId = id
        //    };
        //    return Json(results);
        //}
        //[HttpPost]
        //public async Task<IActionResult> CartSummary()
        //{
        //    var cart = ShoppingCart.GetCart(this.HttpContext);
        //    ViewData["CartCount"] =await cart.GetCount();
        //    return PartialView("");
        //}

        public ViewResult Index(string returnUrl)
        {
            return View(new ShoppingCartViewModel
            {
                ShoppingCart = _cartService,
                ReturnUrl = returnUrl
            });
        }


        public RedirectToActionResult AddToCart(int productId,string returnUrl)
        {
            var album = _myContext.Albums.FirstOrDefault(a => a.AlbumId == productId);
           
            if (album!=null)
            {
                _cartService.AddItem(album, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            var album = _myContext.Albums.FirstOrDefault(a => a.AlbumId == productId);

            if (album != null)
            {
                _cartService.RemoveLine(album);
            }
            return RedirectToAction("Index", new { returnUrl });
        }



        //private ShoppingCart GetShoppingCart()
        //{
        //    ShoppingCart shoppingCart =HttpContext.Session.GetJson<ShoppingCart>("ShoppingCart")?? new ShoppingCart();
        //    return shoppingCart;
        //}

        //private void SaveCart(ShoppingCart shoppingCart)
        //{
        //    HttpContext.Session.SetJson("ShoppingCart", shoppingCart);
        //}
    }
}