using Microsoft.AspNetCore.Mvc;

namespace JuanApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
