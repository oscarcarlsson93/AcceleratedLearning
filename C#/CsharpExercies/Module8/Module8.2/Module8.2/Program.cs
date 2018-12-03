using System;
using System.IO;

namespace Module8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a file name: ");
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string filename = Console.ReadLine();
                    File.CreateText(filename);
                    Console.ResetColor();
                    Console.WriteLine($"The file {filename} is now created");
                    Console.WriteLine();
                    break;
                }
                catch (UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are not authorized to create this file");
                    Console.ResetColor();
                }
                //catch (IOException)
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine("Input output exception");
                //    Console.ResetColor();
                //}
                catch (ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Något är fel på filnamnet!");
                    Console.ResetColor();
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The filename is not valid");
                    Console.ResetColor();
                }
            }




        }
    }
}
