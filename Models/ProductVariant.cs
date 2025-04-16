using System.ComponentModel.DataAnnotations;

namespace Sneaker_City.Models
{
    public class ProductVariant
    {
        [Key]
        public int VariantId { get; set; }
        public int ProductId { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }
    }

}
