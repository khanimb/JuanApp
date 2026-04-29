using JuanApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JuanApp.Areas.Manage.Controllers;
[Area("Manage")]
    public class DashboardController : Controller
    {
        private readonly JuanAppDbContext _context;

        public DashboardController(JuanAppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
