using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
        [Key]
        public int CartId { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public string ReturnUrl { get; set; }

    }
}
