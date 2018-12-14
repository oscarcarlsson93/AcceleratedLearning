using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint03
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 8, 3, 11 };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Listan");
            Console.ResetColor();
            foreach (var item in numbers)
            {
                DisplayList(item);            
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Multiplicera med 100 och lägg till 3");
            Console.ResetColor();

            MultiplyBy100AndAdd3(numbers);
            Console.WriteLine();
            Console.WriteLine();

           // List<string> result = ReorderList(new List<string> { "a", "b", "c", "d" }, new List<int> { 3, 1, 4, 2 });

        }

        public List<string> ReorderList(List<string> list1, List<int> list2)
        {
            var result = new List<string>();
            foreach (var item in list2)
            {                
          result.Add(list1[item-1]);                
            }
            return result;
        }

        private static void MultiplyBy100AndAdd3(List<int> numbers)
        {           
            foreach (var item in numbers.Select(x=> x * 100 + 3))
            {
                DisplayList(item);
            }           
        }

        private static void DisplayList(int item)
        {
            Console.Write($"{item}, ");
        }
           
    }
}
