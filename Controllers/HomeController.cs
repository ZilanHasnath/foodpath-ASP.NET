using Microsoft.AspNetCore.Mvc;
using dotnet.Models;

namespace dotnet.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new LandingPageViewModel
            {
                Product = new ProductDetails
                {
                    Name = "Dhakaiya Shahi Alur Chop",
                    Tagline = "Hot, Crispy & Authentic Bangladeshi Street-Style Potato Fritter",
                    Price = 80.00m,
                    Rating = 4.9f,
                    ReviewCount = 240,
                    Description = "Spiced mashed potato loaded with fried onions, roasted dried red chili, and local aromatics, dipped in a rich gram flour batter and fried to golden perfection.",
                    Ingredients = new[] { "Mashed Potato", "Beresta (Fried Onion)", "Dry Red Chili", "Bhaja Masala", "Gram Flour Batter", "Mustard Oil" },
                    Highlights = new[]
                    {
                        "Authentic Old Dhaka Street Recipe",
                        "Served Hot with Tangy Tamarind Tok & Cucumber",
                        "100% Halal & Made Fresh Daily",
                        "Traditional Bangladeshi Spice Blend"
                    }
                }
            };
            return View(model);
        }
    }
}