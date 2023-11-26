using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrcaticTask.Data;

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
    }
}