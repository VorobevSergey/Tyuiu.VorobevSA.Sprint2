using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint2.Task3.V1.Lib;

namespace Tyuiu.VorobevSA.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService service1 = new DataService();
            double x = 4;
            double res = service1.Calculate(x);
            double wait = 5.945;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService service1 = new DataService();
            double x = 2;
            double res = service1.Calculate(x);
            double wait = -17.027;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate3()
        {
            DataService service1 = new DataService();
            double x = -4;
            double res = service1.Calculate(x);
            double wait = -43.75;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate4()
        {
            DataService service1 = new DataService();
            double x = -8;
            double res = service1.Calculate(x);
            double wait = -87.998;
            Assert.AreEqual(wait, res);
        }
    }
}
