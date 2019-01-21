using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint06
{
    class Program
    {
        static void Main(string[] args)
        {
            RecreateDatabase();

            AddSpaceship("USS Enterprise");
            AddSpaceship("Millennium Falcon");
            AddSpaceship("Cylon Raider");

            AddRavioliForSpaceship("Cylon Raider", 1, "2018-04-19");
            AddRavioliForSpaceship("Millennium Falcon", 1, "2017-01-01");
            AddRavioliForSpaceship("Millennium Falcon", 2, "2018-01-01");
            AddRavioliForSpaceship("Nalle Puh", 99, "1950-01-01");

            List<Spaceship> list = GetAllSpaceships();
           DisplaySpaceships(list);
        }

        private static void AddRavioliForSpaceship(string v1, int v2, string v3)
        {
            SpaceContext context = new SpaceContext();
           //ravioliStorage = new List<Ravioli>();

            //DateTime date = DateTime.Parse(v3);
            //context.Ravioli.Add(new Ravioli { Date = date, Id =  });
            //context.Spaceship.Add(new Ravioli)
            
             


        }

        private static void DisplaySpaceships(List<Spaceship> list)
        {
            foreach (Spaceship item in list)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine();
            }
        }

        private static List<Spaceship> GetAllSpaceships()
        {
            SpaceContext context = new SpaceContext();
            return context.Spaceship.ToList();
        }

        private static void AddSpaceship(string v)
        {
            SpaceContext context = new SpaceContext();

            context.Spaceship.Add(new Spaceship { Name = v });
            context.SaveChanges();
        }

        private static void RecreateDatabase()
        {
            using (var context = new SpaceContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
