using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Miniprojekt01.Models;

namespace Miniprojekt01.Services
{
    public class PokemonRepository
    {
        private IHostingEnvironment _env;
        public PokemonRepository(IHostingEnvironment env)
        {
            _env = env;
        }

        internal List<Pokemon> GetAll()
        {
            string root = _env.ContentRootPath;
            string filename = Path.Combine(root, "Data", "pokemons.txt");
            string[] lines = File.ReadAllLines(filename);
            List<Pokemon> pokemonList = new List<Pokemon>();
            foreach (var x in lines)
            {
                string[] pokemon = x.Split(",");
                pokemonList.Add(new Pokemon { Id = int.Parse(pokemon[0]), Name = pokemon[1], PokemonType = Enum.Parse<PokemonType>(pokemon[2]), ImageName = pokemon[3] });

            }
            return pokemonList;
        }

        internal Pokemon GetByName(string name)
        {
            return GetAll().Where(x => x.Name.ToLower() == name.ToLower()).Single();
        }

        internal Pokemon GetById(int id)
        {
            return GetAll().Where(x => x.Id == id).Single();

        }

    }
}
