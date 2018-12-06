using System;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberToNumber
    {
        public int SumNumbersTo(int input)
        {
            if (input <= 0)
            
                throw new ArgumentException();
            
            return Enumerable.Range(1, input).Sum();
        }

        public int SumNumbersTo_WithoutLinq(int input)
        {          
                if (input <= 0)
                {
                    throw new ArgumentException();
                }

                int result = 0;

                for (int i = 0; i < input; i++)
                {
                    result += i;
                }
                return result;            
        }

        public int SumNumbers(int from, int to)
        {
            if (to < from)
                throw new ArgumentException();

            return Enumerable.Range(from, to - from + 1).Sum();
        }

        public int SumNumbersDividedByThreeOrFive(int input)
        {
            if (input <= 0)
            {
                throw new ArgumentException();
            }
            return Enumerable.Range(1, input).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
