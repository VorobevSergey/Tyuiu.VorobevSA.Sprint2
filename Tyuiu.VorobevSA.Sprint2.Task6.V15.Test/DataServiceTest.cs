using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint2.Task6.V15.Lib;

namespace Tyuiu.VorobevSA.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService service1 = new DataService();
            int k = 251;
            Assert.AreEqual("Суббота", service1.FindDayName(k));
        }
    }
}
