using System;
using System.Collections.Generic;

namespace Module10._4
{
    class Program
    {

        static void Main(string[] args)
        {

            List<string> nameList = new List<string>();
            while (true)
            {
                Console.Write("Enter a name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                Console.ResetColor();
                //Gör om till metoder

                if (input == "QUIT")
                {
                    break;
                }
                else
                {
                    nameList.Add(input);
                    nameList.Sort();

                }

            }

            nameList.Remove("QUIT");
            nameList.RemoveAt(0);
            nameList.RemoveAt(nameList.Count - 1);
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }
}
