using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class HomeWorkSeven
    {
        /// <summary>
        /// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
        /// m = 3, n = 4.
        /// 0,5 7 -2 -0,2
        /// 1 -3,3 8 -9,9
        /// 8 7,8 -7,1 9
        /// </summary>
        public void Task47()
        {
            int m = 3, n = 4;
            double[,] arr = ArrayHelpers.Create2dArray<double>(m, n);
            arr.FillDoubleRandomNumbers(-10.0, 10.0);
            arr.Print(' ', '\n', el => string.Format("{0:0.00}", el));
        }

        /// <summary>
        /// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
        /// Например, задан массив:
        /// 1 4 7 2
        /// 5 9 2 3
        /// 8 4 2 4
        /// 17 -> такого числа в массиве нет
        /// </summary>
        public void Task50()
        {
            int[,] arr = ArrayHelpers.Create2dArray<int>();

            arr.FillIntRandomNumbers(1, 10);
            arr.Print();

            Console.WriteLine();
            Console.WriteLine("Для доступа к элементу введите его позицию, нумерация начинается с 0");

            int columnInput = ReadUtils.ReadInt("Введите номер столбца");
            int rowInput = ReadUtils.ReadInt("Введите номер строки");
            arr.PrintElementByPosition(columnInput, rowInput);
        }

        /// <summary>
        /// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        /// Например, задан массив:
        /// 1 4 7 2
        /// 5 9 2 3
        /// 8 4 2 4
        /// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
        /// </summary>
        public void Task52()
        {
            int[,] matrix = ArrayHelpers.Create2dArray<int>(3,4);
            matrix.FillIntRandomNumbers(1, 10);
            matrix.Print();

            double[] res = AverageSumOfEachColumn(matrix);
            Console.WriteLine("Суума столбцов: ");
            Console.WriteLine(string.Join("; ", res.Select(el => string.Format("{0:0.#}", el))));
        }
        private static double[] AverageSumOfEachColumn(int[,] matrix)
        {
            double[] result = new double[matrix.GetLength(1)];

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, j];
                }
                sum /= matrix.GetLength(0);
                result[j] = sum;
            }
            return result;
        }
    }
}
