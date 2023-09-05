using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    public class SpecshipsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
