using JuanApp.Data;
using JuanApp.Extentions;
using JuanApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JuanApp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SliderController : Controller
    {
        private readonly JuanAppDbContext _context;

        public SliderController(JuanAppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Slider slider)
        {
            if (slider.File == null)
            {
                ModelState.AddModelError("File", "Zəhmət olmasa şəkil seçin.");
            }

            if (!ModelState.IsValid) return View(slider);

            if (!slider.File.IsImage())
            {
                ModelState.AddModelError("File", "Fayl şəkil formatında olmalıdır.");
                return View(slider);
            }

            if (slider.File.IsValidSize(2))
            {
                ModelState.AddModelError("File", "Şəkil ölçüsü 2MB-dan çox olmamalıdır.");
                return View(slider);
            }

            slider.ImageUrl = slider.File.SaveFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "img", "slider"));

            _context.Sliders.Add(slider);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Slider slider = _context.Sliders.Find(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Slider slider)
        {
            Slider existSlider = _context.Sliders.Find(id);
            if (existSlider == null) return NotFound();

            if (!ModelState.IsValid) return View(slider);

            if (slider.File != null)
            {
                if (!slider.File.IsImage())
                {
                    ModelState.AddModelError("File", "Fayl şəkil formatında olmalıdır.");
                    return View(slider);
                }
                if (slider.File.IsValidSize(2))
                {
                    ModelState.AddModelError("File", "Şəkil ölçüsü 2MB-dan çox olmamalıdır.");
                    return View(slider);
                }

                string oldPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "img", "slider", existSlider.ImageUrl);
                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }

                existSlider.ImageUrl = slider.File.SaveFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "img", "slider"));
            }

            existSlider.Title = slider.Title;
            existSlider.Description = slider.Description;
            existSlider.ButtonText = slider.ButtonText;
            existSlider.ButtonUrl = slider.ButtonUrl;

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Slider slider = _context.Sliders.Find(id);
            if (slider == null) return NotFound();

            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "img", "slider", slider.ImageUrl);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _context.Sliders.Remove(slider);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}