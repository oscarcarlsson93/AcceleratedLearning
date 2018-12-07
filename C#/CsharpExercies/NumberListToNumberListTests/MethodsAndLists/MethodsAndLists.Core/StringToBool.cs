using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MethodsAndLists.Core
{
    public class StringToBool
    {
        public bool IsPalindrome(string word)
        {
            if (string.IsNullOrWhiteSpace(word) )
            {
                throw new ArgumentException();
            }
            if (word == null)
            {
                throw new ArgumentException();
            }
            
            // Lösning 1
            //var input = word;
            //string reversed = new string(input.Reverse().ToArray());
            //var palindrome = input == reversed;
            //return palindrome;

            //Lösning 2
            return word.SequenceEqual(word.Reverse());
        }

        public bool IsZipCode(string code)
        {
            return Regex.IsMatch(code ?? "", @"^[1-9]\d\d [1-9]\d$");
        }
    }
}
