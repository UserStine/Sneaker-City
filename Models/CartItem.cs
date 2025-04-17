﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Sneaker_City.Models
{
    [NotMapped] 
    public class CartItem
    {
        public int ProductId { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; } = 1;
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }


        }
}
