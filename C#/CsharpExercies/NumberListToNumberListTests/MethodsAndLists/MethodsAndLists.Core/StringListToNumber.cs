using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndLists.Core
{
    public class StringListToNumber
    {
        public int ElevatorGoUpAndDown(string[] input)
        {
            if (input == null)
            {
                return 0;
            }

            int counter = 0;
            foreach (var item in input)
            {
                if (item == "UPP")
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
            }
            return counter;
        }

        public int ElevatorGoUpAndDown_Linq(string[] input)
        {
            return input.Count(x => x == "UPP") - input.Count(x => x == "NER");
        }
    }
}
