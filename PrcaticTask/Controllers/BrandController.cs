using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrcaticTask.Data;
using PrcaticTask.Models;

namespace PrcaticTask.Controllers
{
    public class BrandController : Controller
    {
        private readonly PrcaticTaskContext _context;

        public BrandController(PrcaticTaskContext context)
        {
            _context = context;
        }
        

        public IActionResult Index()
        {
            var brands = _context.Brand.ToList();
            return View(brands);
        }


        public IActionResult CreateBrand()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBrand(Brand brand)
        {
            _context.Brand.Add(brand);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}