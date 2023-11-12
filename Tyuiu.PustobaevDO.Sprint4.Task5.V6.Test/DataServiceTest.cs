using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PustobaevDO.Sprint4.Task5.V6.Lib;
namespace Tyuiu.PustobaevDO.Sprint4.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] m = { {3, 1, -3 },
                         {-4,-5,5 },
                         {0, 9, 11 } };

            int[,] wait = { { 1, 1, -3 },
                            { -4, -5, 1 },
                            { 0, 1, 1} };
            int[,] res = ds.Calculate(m);
            CollectionAssert.AreEqual(wait, res);

        }
    }
}