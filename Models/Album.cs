using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Album
    {
        
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        [Required]
        [Display(Name = "Title")]
        [StringLength(32)]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Price")]
        [Range(0.01,100.00,ErrorMessage ="Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }
        [Required]
        [Display(Name = "AlbumArtUrl")]
        [StringLength(64)]
        public string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual List<OrderDetail> OrderDetail { get; set; }
    }
}
