using Microsoft.AspNetCore.Mvc;
using Sneaker_City.Data;
using Sneaker_City.Extensions;
using Sneaker_City.Models;

using System.Collections.Generic;
using System.Linq;
using Sneaker_City.Models.ViewModels;


namespace Sneaker_City.Controllers
{
    public class CartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Carts/Create
        [HttpGet]
        public IActionResult Create()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Carts") ?? new List<CartItem>();
            return View(cart);
        }

        // POST: /Carts/AddToCart
        [HttpPost]
        public IActionResult AddToCart(int productId, string size, int quantity)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product == null || string.IsNullOrEmpty(size) || quantity <= 0)
            {
                return RedirectToAction("Index", "Home");
            }

            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Carts") ?? new List<CartItem>();

            var existingItem = cart.FirstOrDefault(c => c.ProductId == productId && c.Size == size);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                cart.Add(new CartItem
                {
                    ProductId = product.ProductId,
                    Size = size,
                    ProductName = $"{product.Brand} {product.Model}",
                    ImageUrl = product.ImageUrl,
                    Price = product.Price,
                    Quantity = quantity
                });
            }

            HttpContext.Session.SetObjectAsJson("Carts", cart);
            return RedirectToAction("Create");
        }

        // GET: /Carts/Index (Shipping form)
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Shipping form view
        }

        // POST: /Carts/Index (Submit shipping info)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ShippingInfo shippingInfo)
        {
            if (!ModelState.IsValid)
            {
                return View(shippingInfo);
            }

            HttpContext.Session.SetObjectAsJson("ShippingInfo", shippingInfo);
            return RedirectToAction("Checkout");
        }

        // GET: /Carts/Checkout
        [HttpGet]
        public IActionResult Checkout()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Carts") ?? new List<CartItem>();
            ShippingInfo shippingInfo = new ShippingInfo();

            var viewModel = new CheckoutViewModel()
            {
                CartItems = cart,
                ShippingInfo = shippingInfo 
            };

            return View(viewModel);

        }
    }
}
