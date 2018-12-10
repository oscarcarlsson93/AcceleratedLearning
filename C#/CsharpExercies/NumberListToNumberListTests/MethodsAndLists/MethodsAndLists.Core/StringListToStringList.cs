using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndLists.Core
{
    public class StringListToStringList
    {
        public IEnumerable<string> GetEverySecondElement(string[] strings)
        {
            if (strings == null)
            {
                throw new ArgumentNullException();
            }

            var result = new List<string>();

            for (int i = 0; i < strings.Length; i++)
            {
                if (i % 2 == 1)
                {
                    result.Add(strings[i]);
                }
            }
            return result;

            // Med Linq
            //var result = strings.Where((x, i) => i % 2 == 1).ToList();
            //return result;
        }
    }
}
