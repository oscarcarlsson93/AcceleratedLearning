using System;

namespace Checkpoint1.Tips
{
    class Program
    {
        static void Main(string[] args)
        {
           DrawSquare(3, 5);
            
        }

        private static void DrawSquare(int v, int indent = 0)
        {
            
            for (int i = 1; i < v; i++)
            {
                string spaces = new string(' ', indent);
                Console.Write(spaces);
                for (int x = 1; x < v; x++)
                {                  
                Console.Write("#");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
