using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sрrint2.Task0.V22.Lib;

namespace Tyuiu.VorobevSA.Sрrint2.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService service1 = new DataService();
            int x = 2105;
            int y = 77;
            bool[] res = new bool[6];
            res = service1.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, true, true, true, false } ;
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
