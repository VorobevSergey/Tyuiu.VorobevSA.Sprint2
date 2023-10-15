using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint2.Task4.V30.Lib;

namespace Tyuiu.VorobevSA.Sprint2.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService service1 = new DataService();
            double x = 5;
            double y = 4;
            double res = service1.Calculate(x, y);
            double wait = 1439.869;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService service1 = new DataService();
            double x = 3;
            double y = 7;
            double res = service1.Calculate(x, y);
            double wait = 7.222;
            Assert.AreEqual(wait, res);
        }
    }
}
