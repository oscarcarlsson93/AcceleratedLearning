using System;
using System.Linq;

namespace Module8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Enter a list of animals: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string animals = Console.ReadLine();
                Console.ResetColor();

                try
                {
                    var animalList = ParseAnimals(animals);
                    Console.WriteLine($"There are {animalList.Length} animals in the list");
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }

                string[] ParseAnimals(string animalsString)
                {
                        if (string.IsNullOrWhiteSpace(animalsString))
                        {
                            throw new ArgumentException("Animal string don't contain any letters");
                        }
                    string[] animalsList = animalsString.Split(',');
                    foreach (var animal in animalsList)
                    {

                        if (animal.Length >= 15)
                        {
                            throw new ArgumentException($"This animal: '{animal}' contains too many letters");
                        }
                        if (!animal.All(c => Char.IsLetter(c)))
                        {
                            throw new ArgumentException($"Animal:{animal} contains invalid letters");
                        }
                        if (string.IsNullOrWhiteSpace(animal))
                        {
                            throw new ArgumentException("One of the animals don't contain any letters");
                        }
                    }
                    return animalsList;
                }
            }
        }
    }
}
