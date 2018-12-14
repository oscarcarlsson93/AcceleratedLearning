using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal:");
            int a = AskForNumber(1, "english");
            int b = AskForNumber(2, "english");
            int sum = a + b;
            DisplaySum(sum, "swedish");

        }

        private static int AskForNumber(int v1, string v)
        {
            while (true)
            {
                Console.Write(v); 
                int number;
                string tal = Console.ReadLine();
                bool valid = int.TryParse(tal, out number);
                if (valid == true)
                {
                    return number;
                }
            }

        }

        private static void DisplaySum(int sum, string v)
        {
            Console.WriteLine(sum);
        }


    }
}
