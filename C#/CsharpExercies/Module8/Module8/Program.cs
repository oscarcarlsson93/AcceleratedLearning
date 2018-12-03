using System;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The chocolate contains 24 pieces");
            Console.Write("How many want to share? ");
            decimal input = decimal.Parse(Console.ReadLine());
            decimal pieces = 24;

            try
            {
                decimal result = AntalBitar(input, pieces);
                Console.WriteLine($"Everyone get {result:.##} pieces");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }

        private static decimal AntalBitar(decimal input, decimal pieces)
        {
            if (input < 0)
            {
                throw new ArgumentException("Felaktig inmatning");
            }
            if (input < 1)
            {
                throw new ArgumentException("Zero people can't divide a chocolate");
            }
           
            return pieces / input;
        }
    }
}
