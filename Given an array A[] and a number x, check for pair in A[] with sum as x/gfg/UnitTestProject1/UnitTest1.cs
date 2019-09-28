using gfg;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_array()
        {
            int[] arr = new int[8] { 1, 2, 3, 4, 5, 11, 10, 9 };
            bool result = ArrayOperation.CheckForPair(arr, 5);

            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void TestMethod_hash()
        {
            int[] arr = new int[8] { 1, 2, 3, 4, 5, 11, 10, 9 };
            bool result = ArrayOperation.CheckForPair_Hash(arr, 5);

            Assert.AreEqual(result, true);
        }
    }
}
