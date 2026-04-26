using Microsoft.AspNetCore.Mvc;

namespace JuanApp.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
