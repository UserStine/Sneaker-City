namespace Sneaker_City.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

}
