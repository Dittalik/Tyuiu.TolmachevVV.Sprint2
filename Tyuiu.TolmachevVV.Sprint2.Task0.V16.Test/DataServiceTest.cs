using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint2.Task0.V16.Lib;

namespace Tyuiu.TolmachevVV.Sprint2.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            bool[] bools = new bool[] { true, false, true, false, true, false };
            for (int i = 0; i < 6; ++i)
            {
                Assert.AreEqual(bools[i], service1.GetCompareOperations(1025, 275)[i]);
            }
        }
    }
}
