using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberListToNumberList
    {

        public List<int> Add70ToEverySecondElement(List<int> numbers)
        {
            var result = new List<int>();
            int counter = 1;
            foreach (int number in numbers)
            {
                int newNumber = number;
                if (counter % 2 == 0)
                
                    newNumber = number + 70;
                
                else
                
                    newNumber = number;
                
                result.Add(newNumber);

                counter++;
            }
            return result;
        }

        public List<int> Add50ToFirstThreeElements(List<int> numbers)
        {
            var addFirst = new List<int>();
            int numberCounter = 1;
                       
                foreach (int number in numbers)
                {
                int newNumber = number;

                if (numberCounter <= 3)
                
                    newNumber = number + 50;
                    addFirst.Add(newNumber);
               
                numberCounter++;
                }            
            return addFirst;
        }

        public List<int> NegateEachNumber(List<int> numbers)
        {
            var negerat = new List<int>();
            foreach (int number in numbers)
            {
                int n = number * -1;
                negerat.Add(n);
            }
            return negerat;
        }

        public List<int> DivideEachNumberBy100(List<int> numbers)
        {
            var delat = new List<int>();
            foreach (int number in numbers)
            {
                int d = number / 100;
                delat.Add(d);
            }
            return delat;
        }

        public List<int> DoubleEachNumber(List<int> numbers)
        {
            var doubled = new List<int>();
            foreach (int number in numbers)
            {
                int d = number * 2;
                doubled.Add(d);
            }
                return doubled;
        }

        public List<int> DoubleEachNumber_Linq(List<int> input)
        {
            var doubledList = input.Select(x => x * 2).ToList();
            return doubledList;
        }

        public List<int> GetNumbersDividableByFive(List<int> numbers)
        {
            var delbart = new List<int>();
            foreach (int number in numbers)
            {
                // 11 / 5 = 2 med resten 1     11 % 5 = 1
                // 12 / 5 = 2 med resten 2     12 % 5 = 2

                if (number % 5 == 0)
                {
                    delbart.Add(number);
                }
            }
            return delbart;
        }

        public List<int> GetNumbersHigherThan1000(List<int> numbers)
        {
            var higherList = new List<int>();

            foreach (var number in numbers)
            {
                if (number >= 1000)
                {
                    higherList.Add(number);
                }
            }
            return higherList;
        }

        public List<int> Add100ToEachNumber(List<int> numbers)
        {
            var hundred = new List<int>();

            foreach (int number in numbers)
            {
                int h = number + 100;
                hundred.Add(h);
            }
            return hundred;
        }

        public List<int> Add100ToEachNumber_Linq(List<int> input)
        {
            return input.Select(x => x + 100).ToList();
        }

        public List<int> GetNumbersHigherThan1000_Linq(List<int> input)
        {
            return input = input.Where(x => x > 1000).ToList();
        }

        public List<int> GetNumbersDividableByFive_Linq(List<int> input)
        {
            return input = input.Where(x => x % 5 == 0).ToList();
        }

        public List<int> DivideEachNumberBy100_Linq(List<int> input)
        {
            return input = input.Select(x => x / 100).ToList();
        }

        public List<int> NegateEachNumber_Linq(List<int> input)
        {
            return input = input.Select(x => x * -1).ToList();
        }

        public List<int> Add50ToFirstThreeElements_Linq(List<int> input)
        {
            var first = input.Take(3).Select(x => x + 50);
            var last = input.Skip(3);
            return first.Concat(last).ToList();
        }
    }
}