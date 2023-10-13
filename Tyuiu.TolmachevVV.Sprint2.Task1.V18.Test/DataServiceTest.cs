using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint2.Task1.V18.Lib;

namespace Tyuiu.TolmachevVV.Sprint2.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            bool[] bools = new bool[] { true, true, true, false, true, false };
            for (int i = 0; i < 6; ++i)
            {
                Assert.AreEqual(bools[i], service1.GetLogicOperations(155, 696, 242, 541)[i]);
            }
        }
    }
}
