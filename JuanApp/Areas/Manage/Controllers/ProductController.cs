using Microsoft.AspNetCore.Mvc;
using JuanApp.Data;
using Microsoft.EntityFrameworkCore;
using JuanApp.Models;

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
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok();
        }

        public IActionResult Detail(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound(); 
            return View (product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Səhifə açılanda dropdown dolsun deyə:
            ViewBag.Categories = _context.Categories.Where(c => !c.IsDeleted).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (product.CategoryId == 0)
            {
                ModelState.AddModelError("CategoryId", "Zəhmət olmasa kateqoriya seçin.");
            }
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = _context.Categories.Where(c => !c.IsDeleted).ToList();
            return View(product);
        }

        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if (product.CategoryId == 0)
            {
                ModelState.AddModelError("CategoryId", "Zəhmət olmasa kateqoriya seçin.");
            }
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = _context.Categories.Where(c => !c.IsDeleted).ToList();
            return View(product);
        }
    }
}