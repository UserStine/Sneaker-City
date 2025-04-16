namespace Sneaker_City.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; } // ✅ This is your primary key

        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; }

        public int Quantity { get; set; }
    }

}
