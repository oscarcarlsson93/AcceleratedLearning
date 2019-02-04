using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mvc01.Models;
using Mvc01.Services;
using Mvc01.ViewModels;
using System.Collections.Generic;

namespace Mvc01.Controllers
{
    public class MvcController : Controller
    {
        private IProductRepository _repo;

        public MvcController(IProductRepository repo)
        {
            _repo = repo;
        }

        
        public IActionResult Testy()
        {
            return View();
            //return Ok("testy");
        }

        public IActionResult Yritää()
        {
            return View();
        }

       public IActionResult Index()
        {

            var listProducts = _repo.GetAll();
            var vm = new ProductListVm();
            var list = new List<SelectListItem>();
            foreach (var product in listProducts)
            {
                list.Add(new SelectListItem
                {
                    Text = product.Name,
                    Value = product.Id.ToString(),

                }
                );
            }

            
            vm.AllProducts = list;

            return View(vm);
        }
        public IActionResult Products()
        {
            return View();
        }

        public IActionResult ListAll()
        {
          
            List<Product> lines = _repo.GetAll();

            return View(lines);
        }

        public IActionResult GetById(int id)
        {

            Product product = _repo.GetById(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            _repo.Add(product);

            return View("ProductAdded", product);
        }
    }
}
