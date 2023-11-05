using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PustobaevDO.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array)
        {
            int rows = 5;
            int columns = array.Length / rows;
            int min = 10000000;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((array[i, j] < min) && (j == 4))
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }
    }
}