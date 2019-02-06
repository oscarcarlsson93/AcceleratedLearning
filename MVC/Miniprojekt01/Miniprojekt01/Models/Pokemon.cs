using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miniprojekt01.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Enum PokemonType { get; set; } //byta till type-kategori, enums.
        public string ImageName { get; set; }
    }
}
