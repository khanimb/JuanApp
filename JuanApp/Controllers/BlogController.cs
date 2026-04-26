using Microsoft.AspNetCore.Mvc;

namespace JuanApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
