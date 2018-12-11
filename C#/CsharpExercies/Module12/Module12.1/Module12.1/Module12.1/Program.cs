using System;
using System.Collections;
using System.Collections.Generic;

namespace Module12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercury"};
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercury"};

            DisplayArrayOfRockStars(rockstarsArray);
            Console.WriteLine();
            DisplayListOfRockStars(rockstarsList);
            Console.WriteLine();
            Console.WriteLine("My rockstars: (ienumerable)");
            DisplayRockStars(rockstarsArray);
            Console.WriteLine();
            Console.WriteLine("My rockstars: (ienumerable)");
            DisplayRockStars(rockstarsList);
            Console.WriteLine();


            void DisplayArrayOfRockStars(string[] rockstars)
            {
                Console.WriteLine("My rockstars: (array");
                foreach (var item in rockstars)
                {                    
                    Console.WriteLine(item);                    
                }
            }
            

            void DisplayListOfRockStars(List<string> rockstars)
            {
                rockstars.Add("Bo");
                Console.WriteLine("My rockstars: (list)");
                foreach (var item in rockstars)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void DisplayRockStars(IEnumerable <string> rockstars)
        {
            foreach (var item in rockstars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
