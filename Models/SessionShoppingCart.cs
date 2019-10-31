using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusicStore.Extensions;
using Newtonsoft.Json;

namespace MusicStore.Models
{
    public class SessionShoppingCart:ShoppingCart
    {
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            SessionShoppingCart cart = session?.GetJson<SessionShoppingCart>("Cart")
            ?? new SessionShoppingCart();
            cart.Session = session;
            return cart;
        }
        [JsonIgnore]
        public ISession Session { get; set; }
        public override void AddItem(Album album, int quantiy)
        {
            base.AddItem(album, quantiy);
            Session.SetJson("Cart", this);
        }
        public override void RemoveLine(Album album)
        {
            base.RemoveLine(album);
            Session.SetJson("Cart", this);
        }
        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
