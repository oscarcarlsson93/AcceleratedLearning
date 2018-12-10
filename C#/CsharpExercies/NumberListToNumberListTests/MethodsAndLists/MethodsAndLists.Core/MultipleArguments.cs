using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MethodsAndLists.Core.Enums;

namespace MethodsAndLists.Core
{
    public class MultipleArguments
    {
        public object Recurisson { get; private set; }

        public List<string> SomeToUpper(List<string> list, List<bool> toUpper)
        {
            var result = new List<string>();
            int index = 0;
            foreach (var word in list)
            {
                if (toUpper[index] == true)
                {
                    result.Add(word.ToUpper());

                }
                else
                    result.Add(word);
                index++;
            }
            return result;
        }

        public List<double> MultiplyAllBy(int factor, List<double> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException();
            }

            var hundred = new List<double>();

            foreach (var number in numbers)
            {
                double h = number * factor;
                hundred.Add(h);
            }
            return hundred;
        }

        public List<double> MultiplyAllBy_Linq(int factor, List<double> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException();
            }
            return numbers.Select(x => x * factor).ToList();
        }

        public List<string> NearbyElements(int position, List<string> list)
        {
            if (position < 0 || position > list.Count - 1)
                throw new ArgumentException();

            var result = new List<string>();

            if (position > 0)

                result.Add(list[position - 1]);

            result.Add(list[position]);
            if (position < list.Count - 1)

                result.Add(list[position + 1]);

            return result;
        }

        public List<List<int>> MultiplicationTable(int rowMax, int colMax)
        {
            if (rowMax <= 0 || colMax <= 0)
            
                throw new ArgumentException();
            
            var table = new List<List<int>>();

            for (int i = 1; i <= rowMax; i++)
            {
                var sublist = new List<int>();

                for (int j = 1; j <= colMax; j++)
                {
                    sublist.Add(i * j);
                }
                table.Add(sublist);
            }
            return table;
        }

        public List<List<int>> MultiplicationTable_Linq(int rowMax, int colMax)
        {
            throw new NotImplementedException();
        }

        public int ComputeSequenceSumOrProduct(int toNumber, bool sum)
        {
            if (sum)
                return ComputeSequence(toNumber, ComputeMethod.Sum);
            else
                return ComputeSequence(toNumber, ComputeMethod.Product);
        }

        public int ComputeSequence(int toNumber, ComputeMethod sum)
        {
            if (toNumber <= 0)
                throw new ArgumentException();

            var range = Enumerable.Range(1, toNumber).ToList();

            switch (sum)
            {
                case ComputeMethod.Sum:
                    return range.Sum();

                case ComputeMethod.Product:
                    return range.Aggregate((a, b) => a * b);

                default:
                    throw new NotImplementedException();
            }


        }

        public int[] CombineLists(int[] list1, int[] list2)
        {
            //var result = new List<int>();

            //foreach (var item in list1)
            //{
            //result.Add(item);
            //    foreach (var tal in list2)
            //    {
            //        result.Add(tal);
            //        list2.
            //        break;
            //    }
            //}
            
            //int[] array = result.ToArray();

            //return array;

            int[] ulist = list1.Union(list2).ToArray();
            return ulist;


            
        }

        public int[] RotateList(int[] list, int rotation)
        {
            throw new NotImplementedException();
        }
    }
}
