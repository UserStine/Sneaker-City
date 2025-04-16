using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sneaker_City.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        public string Description { get; set; }

        [Range(0.0, Double.MaxValue)]
        public decimal Price { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public ICollection<ProductVariant> Variants { get; set; }
    }
}
