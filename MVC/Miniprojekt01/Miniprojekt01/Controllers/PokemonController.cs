using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Miniprojekt01.Models;
using Miniprojekt01.Services;
using Miniprojekt01.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miniprojekt01.Controllers
{
    public class PokemonController : Controller
    {
        private PokemonRepository _repo;

        public PokemonController(PokemonRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Testy()
        {
            return View();
        }

        public IActionResult ListAll()
        {
            var x = new PokemonTypeListVm();

            List<Pokemon> pokemons = _repo.GetAll();

            x.AllPokemons = pokemons;

            return View(x);
        }

        public IActionResult GetById(int id)
        {

            Pokemon pokemon = _repo.GetById(id);

            return View(pokemon);
        }
        public IActionResult GetByName(string name)
        {
            Pokemon pokemon = _repo.GetByName(name);
            return View("GetById", pokemon);
        }


        public IActionResult GetByType()
        {

            var listProducts = _repo.GetAll();
            var vm = new PokemonTypeListVm();
            var list = new List<SelectListItem>();
            foreach (var product in listProducts)
            {
                list.Add(new SelectListItem
                {
                    Text = product.PokemonType.ToString(),
                    Value = product.PokemonType.ToString(),

                }
                );
            }


            vm.AllPokemonTypes = list;

            return View("GetById", vm);
        }

    }
}
