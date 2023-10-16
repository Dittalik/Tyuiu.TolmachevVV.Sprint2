using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint2.Task5.V10.Lib;

namespace Tyuiu.TolmachevVV.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDateOfPreviousDayCheck()
        {
            DataService service1 = new DataService();
            Assert.AreEqual("31.12.23", service1.FindDateOfPreviousDay(24, 1, 1));
        }
    }
}
