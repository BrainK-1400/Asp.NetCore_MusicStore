using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class ShoppingCart
    {
        
        private List<Cart> lineCollection = new List<Cart>();

        // 添加进购物车
        public virtual void AddItem(Album album,int quantiy)
        {
            Cart cart = lineCollection.Where(a => a.AlbumId == album.AlbumId).FirstOrDefault();
            if (cart==null)
            {
                lineCollection.Add(new Cart
                {
                    Album=album,
                    AlbumId=album.AlbumId,
                    DateCreated=DateTime.Now,
                    Count=quantiy
                });
            }
            else
            {
                cart.Count += quantiy;
            }
        }

        // 从购物车删除
        public virtual void RemoveLine(Album album) 
            => lineCollection.RemoveAll(l => l.Album.AlbumId == album.AlbumId);

        // 计算总价
        public virtual decimal ComputeTotalValue() 
            => lineCollection.Sum(e => e.Album.Price * e.Count);

        // 清空购物车
        public virtual void Clear() 
            => lineCollection.Clear();

        // 用于foreach啦
        public virtual IEnumerable<Cart> Lines 
            => lineCollection;

        [Key]
        public int ShoppingCartId { get; set; }

    }
}
