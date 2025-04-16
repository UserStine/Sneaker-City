using System;
using System.Linq;
using System.Collections.Generic;
using Sneaker_City.Models;

namespace Sneaker_City.Data
{
    public static class DbSeeder
    {
        public static void SeedProducts(ApplicationDbContext context)
        {
            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product
                    {
                        Brand = "Nike",
                        Model = "Air Force 1",
                        Description = "Classic white sneakers that never go out of style.",
                        Price = 120.00M,
                        ImageUrl = "/images/Nikeair.jpeg",
                        ReleaseDate = new DateTime(2023, 6, 1),
                        Variants = new List<ProductVariant>
                        {
                            new ProductVariant { Size = "8", Color = "White" },
                            new ProductVariant { Size = "9", Color = "White" }
                        }
                    },
                    new Product
                    {
                        Brand = "Adidas",
                        Model = "Ultraboost",
                        Description = "Comfort and energy return like never before.",
                        Price = 180.00M,
                        ImageUrl = "/images/Adidas.jpeg",
                        ReleaseDate = new DateTime(2024, 2, 15),
                        Variants = new List<ProductVariant>
                        {
                            new ProductVariant { Size = "10", Color = "Black" },
                            new ProductVariant { Size = "11", Color = "Gray" }
                        }
                    },
                    new Product
                    {
                        Brand = "Puma",
                        Model = "RS-X",
                        Description = "Retro styling with futuristic vibes.",
                        Price = 110.00M,
                        ImageUrl = "/images/Puma.jpeg",
                        ReleaseDate = new DateTime(2023, 9, 10),
                        Variants = new List<ProductVariant>
                        {
                            new ProductVariant { Size = "9", Color = "Multicolor" },
                            new ProductVariant { Size = "10", Color = "Blue" }
                        }
                    },
                    new Product
                    {
                        Brand = "New Balance",
                        Model = "574 Core",
                        Description = "Iconic style and comfort in one package.",
                        Price = 85.00M,
                        ImageUrl = "/images/New Balance.jpeg",
                        ReleaseDate = new DateTime(2023, 12, 5),
                        Variants = new List<ProductVariant>
                        {
                            new ProductVariant { Size = "8.5", Color = "Navy" },
                            new ProductVariant { Size = "9.5", Color = "Gray" }
                        }
                    },
                    new Product
                    {
                        Brand = "Converse",
                        Model = "Chuck Taylor All Star",
                        Description = "Timeless high-top sneaker.",
                        Price = 60.00M,
                        ImageUrl = "/images/converse.jpg",
                        ReleaseDate = new DateTime(2024, 1, 10),
                        Variants = new List<ProductVariant>
                        {
                            new ProductVariant { Size = "7", Color = "Black" },
                            new ProductVariant { Size = "8", Color = "White" }
                        }
                    },
                    new Product
                    {
                        Brand = "Reebok",
                        Model = "Classic Leather",
                        Description = "Old-school sneakers with premium leather.",
                        Price = 75.00M,
                        ImageUrl = "/images/reebok.jpg",
                        ReleaseDate = new DateTime(2023, 11, 22),
                        Variants = new List<ProductVariant>
                        {
                            new ProductVariant { Size = "10", Color = "White" },
                            new ProductVariant { Size = "11", Color = "Beige" }
                        }
                    },
                    new Product
                    {
                        Brand = "Jordan",
                        Model = "Retro 1",
                        Description = "High-flying style from the legend himself.",
                        Price = 150.00M,
                        ImageUrl = "/images/jordan1.jpg",
                        ReleaseDate = new DateTime(2024, 4, 1),
                        Variants = new List<ProductVariant>
                        {
                            new ProductVariant { Size = "9", Color = "Red/Black" },
                            new ProductVariant { Size = "10", Color = "Blue/White" }
                        }
                    },
                    new Product
                    {
                        Brand = "Vans",
                        Model = "Old Skool",
                        Description = "Skate culture classic with signature side stripe.",
                        Price = 65.00M,
                        ImageUrl = "/images/vans.jpg",
                        ReleaseDate = new DateTime(2023, 10, 12),
                        Variants = new List<ProductVariant>
                        {
                            new ProductVariant { Size = "8", Color = "Black/White" },
                            new ProductVariant { Size = "9", Color = "Red/White" }
                        }
                    },
                    new Product
                    {
                        Brand = "Under Armour",
                        Model = "HOVR Phantom",
                        Description = "Responsive cushioning and sock-like fit.",
                        Price = 140.00M,
                        ImageUrl = "/images/hovr.jpg",
                        ReleaseDate = new DateTime(2024, 3, 18),
                        Variants = new List<ProductVariant>
                        {
                            new ProductVariant { Size = "10", Color = "Gray" },
                            new ProductVariant { Size = "11", Color = "White" }
                        }
                    },
                    new Product
                    {
                        Brand = "ASICS",
                        Model = "Gel-Kayano 28",
                        Description = "Stability and comfort for long runs.",
                        Price = 160.00M,
                        ImageUrl = "/images/asics.jpg",
                        ReleaseDate = new DateTime(2024, 5, 1),
                        Variants = new List<ProductVariant>
                        {
                            new ProductVariant { Size = "9", Color = "Blue/Green" },
                            new ProductVariant { Size = "10.5", Color = "Orange" }
                        }
                    }
                };

                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
