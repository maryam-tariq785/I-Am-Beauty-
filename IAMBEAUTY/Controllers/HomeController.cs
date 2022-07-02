using IAMBEAUTY.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IAMBEAUTY.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult contactForm(string uname, string lname, string email, string phone)
        {
            if (uname == "Maryam" && lname == "abc" && email == "abc@gmail.com" && phone == "123")
            {
                ViewBag.Message = "Login Successfull";
            }
            else
            {
                ViewBag.Message = "Login failed";
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}