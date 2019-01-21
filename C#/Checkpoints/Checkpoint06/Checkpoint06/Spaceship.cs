using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint06
{
    public class Spaceship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ravioli> RavioliStorage { get; set; }


        public Spaceship()
        {
            RavioliStorage = new List<Ravioli>();
        }

        internal void AddRavioliForSpaceship(string v1, int v2, string v3)
        {
            DateTime date = DateTime.Parse(v3);

            RavioliStorage.Add(new Ravioli { Date = date });
        }
        
    }
}
