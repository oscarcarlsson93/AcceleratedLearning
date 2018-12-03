using System;

namespace Module6._4
{


    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person
            {
                Firstname = "Lisa",
                Lastname = "Smith",
                genders = Gender.Female,
                Birthday = new DateTime(1993, 01, 06),
                FavoriteSport = Sport.Squash,
            };

            Console.WriteLine($"Lisa is {p.genders.ToString().ToLower()}");
            Console.WriteLine($"{p.Firstname} likes to play {p.FavoriteSport.ToString().ToLower()}");

            if (p.FavoriteSport == Sport.Rugby)
            {
                Console.WriteLine("Lisa likes to play squash");
            }
            else
            {
                Console.WriteLine("Lisa dont like rugby");
            }
            Console.WriteLine();
        }

        enum Sport
        {
            Tennis, Rugby, Soccer, Hurling, Squash
        }
        enum Gender
        {
            Female, Male, Other
        }

        class Person
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public DateTime Birthday { get; set; }
            public Sport FavoriteSport { get; set; }
            public Gender genders { get; set; }
        }

        

    }

}


    
