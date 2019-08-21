using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Album
    {
        [Required(ErrorMessage ="An album title is required")]
        [StringLength(160)]
        public string Title { get; set; }
        [Range(0.01, 100.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }
        [ScaffoldColumn(false)]
        public int AlbumID { get; set; }
        [DisplayName("Genre")]
        public int GenreID { get; set; }
        [DisplayName("Artist")]
        public int ArtistID { get; set; }
        [DisplayName("Album Art URL")]
        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual List<OrderDetails> OrderDetails { get; set; }
    }
}
