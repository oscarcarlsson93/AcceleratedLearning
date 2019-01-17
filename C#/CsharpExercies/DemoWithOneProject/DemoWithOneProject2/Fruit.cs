using System;
using System.Collections.Generic;
using System.Text;

namespace DemoWithOneProject2
{
    class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
       //public decimal? Price { get; set; } //? = kan vara Null i databasen
        public FruitCategory Category { get; set; }
    }
}
