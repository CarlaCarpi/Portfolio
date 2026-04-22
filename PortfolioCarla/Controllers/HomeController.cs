using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PortfolioCarla.Models;

namespace PortfolioCarla.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

    }
}
