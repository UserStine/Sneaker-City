using Microsoft.AspNetCore.Mvc;
using Sneaker_City.Models;
using Sneaker_City.Extensions; // ✅ Use your existing session helper



namespace Sneaker_City.Controllers
{
    public class ShippingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ShippingInfo());
        }

        [HttpPost]
        public IActionResult Index(ShippingInfo shipping)
        {
            if (!ModelState.IsValid)
            {
                return View(shipping);
            }

            // ✅ Save shipping info to session using your helper
            HttpContext.Session.SetObjectAsJson("ShippingInfo", shipping);

            // 🔁 Redirect to billing page
            return RedirectToAction("Billing");
        }

        [HttpGet]
        public IActionResult Billing()
        {
            // ✅ Retrieve shipping info
            var shipping = HttpContext.Session.GetObjectFromJson<ShippingInfo>("ShippingInfo");

            if (shipping == null)
            {
              return RedirectToAction("Checkout", "Carts");
            }

            return View(shipping);
        }
    }
}

