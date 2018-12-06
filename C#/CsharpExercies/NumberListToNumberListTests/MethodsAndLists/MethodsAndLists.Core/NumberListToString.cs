using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberListToString
    {
        // Demo: returnera "fjärde talet är jättestort" om det är större än 10000

        public string ReportNumberOfNegativeValues(List<int> numbers)
        {

            throw new NotImplementedException();

        }

        public string ReportIfAllValuesAreHigherThan100(List<int> numbers)
        {

            bool highNumbers = true;
            foreach (int number in numbers)
            {
                if (number <= 100)
                
                    highNumbers = false;                               
            }
                if (highNumbers)               
                    return "Alla nummer är högre än 100";               
                else                
                    return "Något nummer är lägre än (eller lika med) 100";                
        }

        public string ReportIfAllValuesAreHigherThan100_Linq(List<int> list)
        {
            int test = list.Where(x => x <= 100).Count();

            return test == 0 ? "Något nummer är lägre än (eller lika med) 100" : "Alla nummer är högre än 100";


        }

        public string ReportFirstAndLastValue(List<int> numbers)
        {
            int first = numbers[0];
                int lastIndex = numbers.Count - 1;
            int last = numbers[lastIndex];
            return $"Första siffran är {first} och sista siffran är {last}";

        }

        public string ReportFirstAndLastValue_Linq(List<int> numbers)
        {
            return "Första siffran är" + numbers.First() + "och sista siffran är" + numbers.Last();

        }
    }
}