using System;
using System.Collections.Generic;

namespace Checkpoint01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write command: ");
            Console.ForegroundColor = ConsoleColor.Green;
         
            string numbers = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();


            // if (numbers.Contains("A"))
            // {
            //     string numbersA = numbers.Remove("A");
            //     Console.WriteLine(numbersA);
            // }
            ////else if (numbers.Contains("B"))
            // {
           // char numbersB = char.Parse
           //     Console.WriteLine("Innehåller B");
           // }
          
            string[] nummerLista = numbers.Split('-');            
            int[] convertedNumbers = Array.ConvertAll(nummerLista, int.Parse);


            //Nummer som börjar med A
            foreach (int nummer in convertedNumbers)
            {

                int val = nummer;
               
                for (int i = 1; i <= val; i++)
                {
                    for (int j = 1; j <= val - i; j++)
                    {
                        Console.Write("");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }

            Console.WriteLine();

            //Nummer som börjar med B
            foreach (int nummer in convertedNumbers)
            {
                int val = nummer;
                int i, j, k;
                for (i = 1; i <= val; i++)
                {
                    for (j = 1; j <= val - i; j++)
                    {
                        Console.Write("");
                    }
                    for (k = 1; k <= j; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
