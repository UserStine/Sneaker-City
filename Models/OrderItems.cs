namespace Sneaker_City.Models
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int VariantId { get; set; }
        public int Quantity { get; set; }

        public Order Order { get; set; }
        public ProductVariant Variant { get; set; }
    }

}
