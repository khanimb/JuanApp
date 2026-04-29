using Microsoft.AspNetCore.Mvc;
using JuanApp.Data;
using Microsoft.EntityFrameworkCore;

namespace JuanApp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController : Controller
    {
        private readonly JuanAppDbContext _context;

        public ProductController(JuanAppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Include(p => p.Category).ToListAsync();
            return View(products);
        }
    }
}