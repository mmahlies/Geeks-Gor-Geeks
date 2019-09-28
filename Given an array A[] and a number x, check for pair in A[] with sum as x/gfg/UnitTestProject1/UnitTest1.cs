using gfg;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_array()
        {
            List<int> list = new List<int>() { 11, 15, 6, 8, 9, 10 };
            int[] arr = list.ToArray();
            int target = 16;
            bool result = ArrayOperation.CheckForPair(arr, target);

            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void TestMethod_hash()
        {
            List<int> list = new List<int>() { 11, 15, 6, 8, 9, 10 };
            int[] arr = list.ToArray();
            int target = 16;
            bool result = ArrayOperation.CheckForPair_Hash(arr, target);

            Assert.AreEqual(result, true);
        }
    }
}
