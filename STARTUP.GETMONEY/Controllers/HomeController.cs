using Microsoft.AspNetCore.Mvc;

namespace GETMONEY.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Conceito()
        {
            return View();
        }
    }
}
