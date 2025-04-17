using System.ComponentModel.DataAnnotations;

namespace Sneaker_City.Models
{
    public class ShippingInfo
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

   

        [Required]
        [Display(Name = "Address Line 1")]
        public string Address1 { get; set; }


        [Required]
        public string Municipality { get; set; }



        [Required]
        [Phone]
        [Display(Name = "Shipping Phone")]
        public string ShippingPhone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

     

        [Required]
        [Display(Name = "Consent to Privacy Policy")]
        public bool PrivacyConsent { get; set; }

        [Required]
        [Display(Name = "Delivery Method")]
        public string DeliveryMethod { get; set; }
    }
}
