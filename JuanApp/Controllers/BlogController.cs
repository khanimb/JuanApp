using Microsoft.AspNetCore.Mvc;
using JuanApp.Data;

namespace JuanApp.Controllers;
    [Area("Manage")]
    public class BlogController : Controller
    {
        private readonly JuanAppDbContext _context;

        public BlogController(JuanAppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int Id)
        {
            var blog = _context.Blogs.FirstOrDefault(x => x.Id == Id);
            return View();
        }
    }
