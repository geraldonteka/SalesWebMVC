using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System.Diagnostics;

namespace SalesWebMVC.Controllers
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

        public IActionResult About()
        {
            ViewData["Message"] = "Sales Web MVC Application";
            ViewData["Author"] = "Epeneto Geraldo Nteka";
            ViewData["Email"] = "geraldonteka10@gmail.com";
            ViewData["LinkedIn"] = "https://www.linkedin.com/in/geraldonteka/";
            ViewData["GitHub"] = "https://github.com/geraldonteka";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}