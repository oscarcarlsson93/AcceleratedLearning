using Microsoft.AspNetCore.Mvc.Rendering;
using Miniprojekt01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miniprojekt01.ViewModels
{
    public class PokemonListVm
    {
        public IEnumerable<SelectListItem> AllPokemons { get; set; }
        public Pokemon pokemon { get; set; }
    }
}
