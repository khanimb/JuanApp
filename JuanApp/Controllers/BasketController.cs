using Microsoft.AspNetCore.Mvc;

namespace JuanApp.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
