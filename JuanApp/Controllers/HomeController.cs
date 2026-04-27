using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using JuanApp.Models;
using JuanApp.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace JuanApp.Controllers
{
    public class HomeController : Controller
    {
        HomeVm homeVm = new HomeVm();
        public IActionResult Index()
        {
            return View();
        }

    }
}
