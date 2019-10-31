using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using Microsoft.AspNetCore.Session;
using System;
using System.Linq;
using MusicStore.ViewModels;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MusicStore.Models
{
    public class ShoppingCart_old
    {
        private readonly MyContext _myContext;

        public ShoppingCart_old(MyContext myContext)
        {
            _myContext = myContext;
        }
        public const string CartSessionKey = "CartId"; // 用于存储SessionKey

        string ShoppingCartId { get; set;}

        public static string GetCart(HttpContext httpContext)
        {
            // TO-DO
            
            return httpContext.Session.GetString(CartSessionKey);
        }


        public static string GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }

        //public void AddToCart(Album album)
        //{
        //    var cartItem = _myContext.Carts.SingleOrDefault(
        //        c=>c.CartId== ShoppingCartId
        //        && c.AlbumId==album.AlbumId
        //        );
        //    if (cartItem==null)
        //    {
        //        cartItem = new Cart
        //        {
        //            AlbumId = album.AlbumId,
        //            CartId = ShoppingCartId,
        //            Count = 1,
        //            DateCreated = DateTime.Now
        //        };
        //        _myContext.Carts.Add(cartItem);
        //    }
        //    else
        //    {
        //        cartItem.Count++;
        //    }
        //    _myContext.SaveChanges();
        //}
        // async Method

        // 添加到购物车（异步）
        public async Task AddToCart(Album album)
        {
            var cartItem =await _myContext.Carts.SingleOrDefaultAsync(
                c => c.CartId == ShoppingCartId
                && c.AlbumId == album.AlbumId
                );
            if (cartItem == null)
            {
                cartItem = new Cart
                {
                    AlbumId = album.AlbumId,
                    CartId = ShoppingCartId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                await _myContext.Carts.AddAsync(cartItem);
            }
            else
            {
                cartItem.Count++;
            }
            await _myContext.SaveChangesAsync();
        }

        // 从购物车删除(异步)
        public async Task RemoveFromCart(int id)
        {
            
            var cartItem =await _myContext.Carts.SingleAsync(
                cart => cart.CartId == ShoppingCartId
                && cart.RecordId==id);
            int itemCount = 0;
            if (cartItem!=null)
            {
                if (cartItem.Count>1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                }
                else
                {
                    _myContext.Carts.Remove(cartItem);
                }
                await _myContext.SaveChangesAsync();
            }
        }

        // 清空购物车(异步)
        public async Task EmptyCart()
        {
            var cartItems = _myContext.Carts.Where(cart => cart.CartId == ShoppingCartId);
            foreach (var cartItem in cartItems)
            {
                _myContext.Carts.Remove(cartItem);
            }
            await _myContext.SaveChangesAsync();
        }


        // 获取购物车列表（异步）
        public async Task<List<Cart>> GetCartItems()
        {
             return await _myContext.Carts.Where(cart => cart.CartId == ShoppingCartId).ToListAsync();
        }

        // TO-DO 
        // 获取当前购物车内物品数量
        public async Task<int> GetCount()
        {
            // 可为null的count
            int? count =await (from cartItems in _myContext.Carts
                          where cartItems.CartId == ShoppingCartId
                          select (int?)cartItems.Count).SumAsync();
            return count ?? 0; // 若都为null，则返回0
        }

        // 获取购物车内总价(异步)
        public async Task<decimal> GetTotal()
        {
            decimal? total = await (from cartItems in _myContext.Carts
                                    where cartItems.CartId == ShoppingCartId
                                    select (int?)cartItems.Count * cartItems.Album.Price).SumAsync();
            return total ?? decimal.Zero; // ?
        }

        // 创建订单
        public async Task<int> CreateOrder(Order order)
        {
            decimal orderTotal = 0;
            var cartItems =await GetCartItems();

            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    AlbumId = item.AlbumId,
                    OrderId = order.OrderId,
                    UnitPrice = item.Album.Price,
                    Quantity = item.Count
                };

                orderTotal += (item.Count * item.Album.Price);
                await _myContext.OrderDetails.AddAsync(orderDetail);
            }

            order.Total = orderTotal;
            await _myContext.SaveChangesAsync();

            await EmptyCart(); // 清空购物车

            return order.OrderId; // 返回订单ID
        }

        // TO-DO
        public string GetCartId(HttpContext httpContext)
        {
            if (httpContext.Session.GetString(CartSessionKey)==null)
            {
                if (!string.IsNullOrWhiteSpace(httpContext.User.Identity.Name))
                {
                    httpContext.Session.SetString(CartSessionKey, httpContext.User.Identity.Name);
                }
                else
                {
                    Guid tempCartId = Guid.NewGuid();
                    httpContext.Session.SetString(CartSessionKey, tempCartId.ToString());
                }
            }
            return httpContext.Session.GetString(CartSessionKey);
        }

        // 迁移购物车
        // 当用户登录时，将购物车迁移至对应用户名下。

        public async Task MigrateCart(string userName)
        {
            var shoppingCart = _myContext.Carts.Where(cart => cart.CartId == ShoppingCartId);
            foreach (Cart item in shoppingCart)
            {
                item.CartId = userName;
            }
            await _myContext.SaveChangesAsync();
        }


    }
}
