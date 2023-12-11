using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using v3.Models;

namespace v3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Introduction()
        {
            return View();
        }
    }
}
