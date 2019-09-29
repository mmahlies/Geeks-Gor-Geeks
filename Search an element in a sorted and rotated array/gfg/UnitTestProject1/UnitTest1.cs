using gfg;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> list = new List<int>() { 5, 6, 7, 8, 9, 10, 1, 2, 3 }; ;
            int targert = 3;
         int result =    ArrayOperaion.Find(list.ToArray(), targert);
            Assert.AreEqual(result, 8);

        }
    }
}
