using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint2.Task7.V12.Lib;

namespace Tyuiu.TolmachevVV.Sprint2.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaCheck()
        {
            DataService service1 = new DataService();
            Assert.IsTrue(service1.CheckDotInShadedArea(-3, 5));
        }
    }
}
