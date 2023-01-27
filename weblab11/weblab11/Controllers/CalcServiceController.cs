using lab_11.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lab_11.Controllers
{
    public class CalcServiceController : Controller
    {
        private readonly ILogger<CalcServiceController> _logger;

        public CalcServiceController(ILogger<CalcServiceController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PassUsingModel()
        {
            var model = new ViewModel();

            return View(model);
        }
        public IActionResult PassUsingViewData()
        {
            Random random = new Random();
            ViewData["num1"] = random.Next(0, 11);
            ViewData["num2"] = random.Next(0, 11);
            return View();
        }
        public IActionResult PassUsingViewBag()
        {
            Random random = new();
            ViewBag.num1 = random.Next(0, 11);
            ViewBag.num2 = random.Next(0, 11);
            return View();
        }
        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}
