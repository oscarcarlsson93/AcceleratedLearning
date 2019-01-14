using Checkpoint05.Domain;
using System;
using System.Collections.Generic;

namespace Checkpoint05
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataAccess = new DataAccess();
            List<Gnome> gnomes = dataAccess.GetGnomesFromDatabase();
            DisplayGnomes(gnomes);
        }

        private static void DisplayGnomes(List<Gnome> gnomes)
        {
            Console.WriteLine("NAMN".PadRight(15) + "HAR SKÄGG".PadRight(15) + "ÄR OND".PadRight(15) + "TEMPERAMENT".PadRight(15) + "RAS");
            foreach (var item in gnomes)
            {
                Console.WriteLine(item.GnomeName.PadRight(15) + item.Beard.PadRight(15) + item.IsEvil.PadRight(15) + item.Temperament.ToString().PadRight(15) + item.Race);
            }
        }
    }
}
