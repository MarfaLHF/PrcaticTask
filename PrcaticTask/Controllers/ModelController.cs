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
    }
}
