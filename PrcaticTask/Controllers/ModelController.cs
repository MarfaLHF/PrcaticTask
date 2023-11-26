using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrcaticTask.Data;
using PrcaticTask.Models;

namespace PrcaticTask.Controllers
{
    public class ModelController : Controller
    {
        private readonly PrcaticTaskContext _context;

        public ModelController(PrcaticTaskContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var models = _context.Model.Include(m => m.Brand).ToList();
            return View(models);
        }


        public IActionResult CreateModel()
        {
            ViewBag.Brands = _context.Brand.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateModel(Model model)
        {
            _context.Model.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> EditModel(int? id)
        {
            ViewBag.Brands = _context.Brand.ToList();

            if (id != null)
            {
                Model? brand = await _context.Model.FirstOrDefaultAsync(p => p.Id == id);
                if (brand != null) return View(brand);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditModel(Model brand)
        {
            _context.Model.Update(brand);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
