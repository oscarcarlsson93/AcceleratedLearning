using System;
using System.Collections.Generic;

namespace Module7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            while (true)
            {
                Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");

                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                Console.ResetColor();

                if (input == "T")
                {
                    Console.Write("Enter the base of the triangle: ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    int baseInput = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Write("Enter the height of the triangle: ");

                    Console.ForegroundColor = ConsoleColor.Green;                
                    int heightInput = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    var t = new Triangle();
                    t.bas = baseInput;
                    t.height = heightInput;
                    shapes.Add(t);
                }
                else if (input == "R")
                {
                    Console.Write("Enter the height of the rectangle: ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    int heightInput = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Write("Enter the width of the ractangle: ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    int widthInput = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    var r = new Rectangle();
                    r.height = heightInput;
                    r.width = widthInput;
                    shapes.Add(r);
                }
                else if (input == "C")
                {
                    Console.Write("Enter the radius of the circle: ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    int radiusInput = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    var c = new Circle();
                    c.Radius = radiusInput;
                    shapes.Add(c);
                }
                else if (input == "D")
                {
                    break;
                }
            }
            Console.WriteLine();

        }
    }
}
