using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Module10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> products = BuildProductDictionary();

            DisplayProductDictionary(products);
        }

        private static void DisplayProductDictionary(Dictionary<int, string> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine();
                Console.WriteLine($"Product ID={item.Key} and name={item.Value}");
            }
        }

        private static Dictionary<int, string> BuildProductDictionary()
        {
            var result = new Dictionary<int, string>();
            while (true)
            {
                Console.Write("Enter a product ID and name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                input = input.Trim();

                if (!ValidInput(input))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string[] splitted = input.Split(',');
                int id = int.Parse(splitted[0]);
                string name = splitted[1];

                if (result.ContainsKey(id))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The product list already contains the id {id}");
                    Console.ResetColor();
                    continue;
                }
                result.Add(id, name);
            }
            return result;
        }

        private static bool ValidInput(string input)
        {
            return Regex.IsMatch(input, @"^\d+,[a-z ]+$", RegexOptions.IgnoreCase);
        }
    }
}
