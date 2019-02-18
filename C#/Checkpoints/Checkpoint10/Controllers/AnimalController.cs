using AnimalFarm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AnimalFarm.Controllers
{
    public class AnimalController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly SiteConfig _siteConfig;

        public AnimalController(DatabaseContext context, SiteConfig siteConfig)
        {
            _context = context;
            _siteConfig = siteConfig;
        }

       

        public IActionResult Index()
        {
            Migrate();
            return View(_context.Animals);
        }

        [HttpPost]
        public IActionResult Add(Animal animal)
        {
            if (_siteConfig.AllowedAnimalNames.Contains(animal.Name))
            {
                _context.Add(animal);
                _context.SaveChanges();


            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {
            _context.RemoveRange(_context.Animals);
            //await _context.Database.ExecuteSqlCommandAsync("DELETE FROM ANIMALS");
            _context.SaveChanges();
            return RedirectToAction("Index");
            //return View("Index", _context.Animals);
        }

        public IActionResult Migrate()
        {
            _context.Database.Migrate();
            ViewData["Message"] = "Database migrated";
            return Ok();
            //return View("Index");
        }
    }
}
