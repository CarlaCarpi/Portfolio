using Microsoft.AspNetCore.Mvc;

namespace PortfolioCarla.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
