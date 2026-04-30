using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop.Infrastructure;

namespace JuanApp.Controllers
{
    public class Login_Register : Controller
    {
        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            return View();
        }
    }
}
