using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PustobaevDO.Sprint4.Task5.V6.Lib;

namespace Tyuiu.PustobaevDO.Sprint4.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService sd = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Пустобаев Д. О.                              | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Пустобаев Дмитрий Олегович | ИСПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, обнуляющую нечётные элементы матрицы 5х5 на [1,8],  *");
            Console.WriteLine("* заполненной вводимыми с клав-ры элементами.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");

            int col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] mx = new int[rows, col];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    mx[i, j] = Convert.ToInt32(Console.ReadLine());


                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{mx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = sd.Calculate(mx);

            Console.WriteLine("Матрица с обнулёнными нечётными элементами: \n");
            for (int i = 0; i < mx.GetLength(0); i++)
            {
                for (int j = 0; j < mx.GetLength(1); j++)
                    Console.Write("{0} ", mx[i, j]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}