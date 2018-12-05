using System;
using System.Collections.Generic;
using System.Linq;

namespace Module11
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 5, 10, 7 };

            //double mySum = Sum(list);
            //double myAvg = Avg(list);
            List<string> starify = StarifyList(list);
            //foreach (var star in starify)
            //{
            //    Console.WriteLine(star);
            //}

            //Console.WriteLine(mySum);
            //Console.WriteLine(myAvg);

            //Linq
            //Console.WriteLine(list.Average());
            //Console.WriteLine(list.Sum());

            List<int> Higher = list.Where(x => x > 5).ToList();
            Console.WriteLine(string.Join(",", Higher));
            List<string> starlistLinq = list.Select(x => "*" + x + "*").ToList();
            Console.WriteLine(starlistLinq);
        }

        private static List<string> StarifyList(List<int> list)
        {
            var result = new List<string>();

            foreach (var i in list)
            {
                result.Add($"*{i}*");


            }
            return result;

        }

        private static double Avg(List<int> list)
        {
            return Sum(list) / list.Count;
        }

        private static double Sum(List<int> list)
        {
            double sum = 0;
            foreach (int tal in list)
            {
                sum = sum + tal;
            }
            return sum;
        }
    }
}
