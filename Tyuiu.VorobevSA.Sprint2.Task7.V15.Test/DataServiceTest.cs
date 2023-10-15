using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint2.Task7.V15.Lib;

namespace Tyuiu.VorobevSA.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(true, service1.CheckDotInShadedArea(1.2, -1.2));
        }
    }
}
