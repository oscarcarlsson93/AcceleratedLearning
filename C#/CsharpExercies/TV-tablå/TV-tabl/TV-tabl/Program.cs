using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TV_tabl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Show> allShows = GetShowsFromTextFile();

            DisplayInfoAboutShows(allShows);

            Console.ReadKey();
        }

        private static void DisplayInfoAboutShows(List<Show> allShows)
        {

            Console.WriteLine("ALLA TITLAR");
            Console.WriteLine();
            foreach (var item in allShows)
            {
                Console.WriteLine(item.Program.ToUpper());
            }
            Console.WriteLine();

            Console.WriteLine("PROGRAM SOM BÖRJAR SENARE ÄN KL 21");
            Console.WriteLine();



            foreach (var item in allShows)
            {

                if (item.Tid >= TimeSpan.Parse("21:00:00"))
                {
                    Console.WriteLine($"{item.Kanal} {item.Tid} {item.Program}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("PROGRAM FRÅN SVT2 I KRONOLOGISK ORDNING");
            Console.WriteLine();
            foreach (var item in allShows)
            {
                if (item.Kanal == "SVT2")
                {
                    Console.WriteLine($"{item.Kanal} {item.Tid} {item.Program}");
                }
            }
            Console.WriteLine("FINNS PROGRAMET KULTURNYHETERNA?");
            Console.WriteLine();

            foreach (var item in allShows)
            {
                if (item.Program == "Kulturnyheterna")
                {
                    Console.WriteLine("JA");
                }

            }
            Console.WriteLine();

            Console.WriteLine("ALLA PROGRAM SOM BÖRJAR 20:00");
            Console.WriteLine();
            foreach (var item in allShows)
            {
                if (item.Tid == TimeSpan.Parse("20:00:00"))
                {
                    Console.WriteLine($"{item.Kanal} {item.Tid} {item.Program}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("ALLA PROGRAM MED STORA BOKSTÄVER");
            Console.WriteLine();


            foreach (var item in allShows)
            {
                Console.WriteLine(item.Program.ToUpper());
            }
            Console.WriteLine();
            Console.WriteLine("ALLA KANALER");
            Console.WriteLine();
            foreach (string show in allShows.Select(x => x.Kanal).Distinct())
            {
                Console.WriteLine(show);
            }

        }

        private static List<Show> GetShowsFromTextFile()
        {
            List<Show> allaShower = new List<Show>();

            string[] shower = File.ReadAllLines(@"C:\Project\AcceleratedLearning\C#\CsharpExercies\TV-tablå\TV.txt");


            foreach (var item in shower)
            {
                var show = new Show();
                var splittad = item.Split('*');
                show.Kanal = splittad[0];
                show.Tid = TimeSpan.Parse(splittad[1]);
                show.Program = splittad[2];

                allaShower.Add(show);
            }
            return allaShower;

        }
    }
}
