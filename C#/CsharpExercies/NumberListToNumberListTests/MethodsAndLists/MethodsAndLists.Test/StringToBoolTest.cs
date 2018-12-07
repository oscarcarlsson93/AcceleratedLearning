using MethodsAndLists.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace MethodsAndLists.Test
{
    [TestClass]
    public class StringToBoolTest
    {
        StringToBool x = new StringToBool();

        [TestMethod]
        public void IsPalindrome()
        {
            StringToBool x = new StringToBool();

            bool result = x.IsPalindrome("ABCBA");
            bool falseresult = x.IsPalindrome("ABCA");
            Assert.IsTrue(result);
            Assert.IsFalse(falseresult);



        }

        [TestMethod]
        public void IsZipCode()
        {
            bool result = x.IsZipCode("123 45");
            bool falseResult = x.IsZipCode("12345");
            Assert.IsTrue(result);
        }






    }
}
