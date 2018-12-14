using Checkpoint03;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Program x = new Program();

        [TestMethod]
        public void ReorderList()
        {
            List<string> result = x.ReorderList(new List<string> { "a", "b", "c", "d" }, new List<int> { 3, 1, 4, 2 });
            var expected = new List<string> { "c", "a", "d", "b" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReorderList_2()
        {
            List<string> result = x.ReorderList(new List<string> { "a", "b", "c", "d" }, new List<int> { 2, 2, 2, 2 });
            var expected = new List<string> { "b", "b", "b", "b" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReorderList_3()
        {
            List<string> result = x.ReorderList(new List<string> { "a", "b", "c", "d", "e", "f", "g", }, new List<int> { 1, 4, 7, 2, 6, 5, 3 });
            var expected = new List<string> {"a", "d", "g", "b", "f", "e", "c" };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
