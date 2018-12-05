using System;
using System.Text.RegularExpressions;

namespace Module10LEK
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Dot Net 100 Pearls";
            Match m = Regex.Match(input, @"\d+");
            Console.WriteLine(m.Value);
        }
    }
}
