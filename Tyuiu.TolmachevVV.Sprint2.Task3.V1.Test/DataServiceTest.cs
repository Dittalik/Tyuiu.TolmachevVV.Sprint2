using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint2.Task3.V1.Lib;

namespace Tyuiu.TolmachevVV.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcCheck()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(9.5, service1.Calculate(2));
        }
    }
}
