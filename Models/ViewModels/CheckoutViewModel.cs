namespace Sneaker_City.Models.ViewModels
{
    public class CheckoutViewModel
    {
        public List<CartItem>? CartItems { get; set; }
        public ShippingInfo? ShippingInfo { get; set; }
    }
}
