using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PustobaevDO.Sprint4.Task3.V16.Lib;

namespace Tyuiu.PustobaevDO.Sprint4.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Пустобаев Д. О. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Пустобаев Дмитрий Олегович | ИСПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 9. Написать программу,      *");
            Console.WriteLine("* которая находит минимальный элемент в последнем столбце массива.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5] { { 5, 8, 5, 8, 4 }, { 2, 3, 4, 6, 3 }, { 1, 1, 2, 9, 9 }, { 6, 7, 4, 1, 2 }, { 5, 7, 1, 8, 7 } };
            int rows = 5;
            int columns = array.Length / rows;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Минимальный элемент в последнем столбце массива = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}