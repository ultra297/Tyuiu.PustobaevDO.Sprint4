using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PustobaevDO.Sprint4.Task2.V26.Lib;

namespace Tyuiu.PustobaevDO.Sprint4.Task2.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт №4 | Выполнил: Пустобаев Д. О. | ИСПб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание №2                                                               *");
            Console.WriteLine("* Вариант #26                                                              *");
            Console.WriteLine("* Выполнил: Пустобаев Дмитрий Олегович | ИСПб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("****************************************************************************");

            int len;
            int multArray;
            Console.Write("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                array[i] = rnd.Next(1, 9);
            }

            Console.WriteLine();

            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            multArray = ds.Calculate(array);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Произведение нечётных элементов массива = " + multArray);


            Console.ReadKey();
        }
    }
}
