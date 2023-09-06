using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SpirinIS.ConsoleApp.Lab0.V0.Lib;

namespace Tyuiu.SpirinIS.ConsoleApp.Lab0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int a = 15;
            int b = 15;

            var res = ds.Calc(a, b);

            Assert.AreEqual(30, res);
        }
    }
}
