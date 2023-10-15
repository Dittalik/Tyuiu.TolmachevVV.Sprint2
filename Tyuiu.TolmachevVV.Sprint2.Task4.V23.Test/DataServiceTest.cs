using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint2.Task4.V23.Lib;

namespace Tyuiu.TolmachevVV.Sprint2.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcCheck()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(1.008, service1.Calculate(2, 16));
        }
    }
}
