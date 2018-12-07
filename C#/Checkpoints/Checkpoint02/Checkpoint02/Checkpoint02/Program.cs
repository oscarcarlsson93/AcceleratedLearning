using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> rumList = new List<Room>();

            Console.WriteLine("Ange namn på rum: ");
            string input = "Kök 59m2 | Vardagsrum 501m2 | Badrum 2m2";
            Console.WriteLine();

            string[] rum = input.Split('|');

            foreach (var item in rum)
            {
                var rummen = new Room();

                string trimmad = item.Trim();
                string utbytt = trimmad.Replace("m2", "");
                string[] rumSplit = utbytt.Split(" ");

                rummen.Rumnamn = rumSplit[0];
                rummen.Area = int.Parse(rumSplit[1]);

                rumList.Add(rummen);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"* Rumnamn {rumList.Count + 0}: {rumSplit[0]}");
            }

            foreach (var item in rumList.OrderByDescending(x => x.Area))
            {
                Console.WriteLine($"* Det största rummet är {item.Rumnamn} på {item.Area}m2");
                break;
            }
            Console.ResetColor();
            Console.WriteLine();

        }
    }
}
