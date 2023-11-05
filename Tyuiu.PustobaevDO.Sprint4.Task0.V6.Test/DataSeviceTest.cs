using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PustobaevDO.Sprint4.Task0.V6.Lib;

namespace Tyuiu.PustobaevDO.Sprint4.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int res = ds.GetSumOddArrEl(array);
            int wait = 32;
            Assert.AreEqual(res, wait);
        }
    }
}
