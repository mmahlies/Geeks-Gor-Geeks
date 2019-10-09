using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrint()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);

            List<int> expextedResult = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> result = new List<int>();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expextedResult[i], result[i]);
            }            
        }
        [TestMethod]
        public void TestPrint2()
        {                                   
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.AddFront(1);
            linkedList.AddFront(2);
            linkedList.AddFront(3);
            linkedList.AddFront(4);
            linkedList.AddFront(5);

            List<int> expextedResult = new List<int>() { 5,4,3,2,1 };
            List<int> result = new List<int>();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expextedResult[i], result[i]);
            }
        }

        [TestMethod]
        public void TestDelete()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);

            linkedList.Delete(3);
            linkedList.Delete(4);


            List<int> expextedResult = new List<int>() { 1, 2, 5 };
            List<int> result = new List<int>();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expextedResult[i], result[i]);
            }

        }


        [TestMethod]
        public void TestDeleteFront()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);

            linkedList.DeleteFront();            
            List<int> expextedResult = new List<int>() {  2, 3,4,5 };
            List<int> result = new List<int>();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expextedResult[i], result[i]);
            }

        }

        [TestMethod]
        public void TestDeleteFront2()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.AddFront(1);
            linkedList.AddFront(2);
            linkedList.AddFront(3);
            linkedList.AddFront(4);
            linkedList.AddFront(5);

            linkedList.DeleteFront();
            linkedList.DeleteFront();
            List<int> expextedResult = new List<int>() { 3, 2, 1 };
            List<int> result = new List<int>();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expextedResult[i], result[i]);
            }

        }
        [TestMethod]
        public void TestReverese()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            linkedList.Revere();
            List<int> expextedResult = new List<int>() { 5,4,3,2,1 };
            List<int> result = new List<int>();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expextedResult[i], result[i]);
            }
        }



    }
}
