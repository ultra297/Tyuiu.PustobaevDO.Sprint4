using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PustobaevDO.Sprint4.Task1.V17.Lib;

namespace Tyuiu.PustobaevDO.Sprint4.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6 };
            int res = ds.Calculate(numsArray);
            int a = 30;
            Assert.AreEqual(30, res);



        }
    }
}
