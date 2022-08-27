using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public static class TwoDArrayExtensions
    {
        public static void FillIntRandomNumbers(this int[,] matrix, int min, int max)
        {
            var randomInstance = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = randomInstance.Next(min, max);
                }
            }
        }

        public static void FillDoubleRandomNumbers(this double[,] matrix, double min, double max)
        {
            var randomInstance = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = randomInstance.NextDouble() * (max-min) + min;
                }
            }
        }

        public static void Print<T>(this T[,] matrix, char delimiterCollumn, char delimeterRow, Func<T, string>? formatFunc)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(formatFunc == null ? matrix[i, j] : formatFunc(matrix[i, j]));
                    Console.Write(delimiterCollumn.ToString());
                }
                Console.Write(delimeterRow.ToString());
            }
        }

        public static void Print<T>(this T[,] matrix)
        {
            matrix.Print(' ', '\n', null);
        }

        public static T GetByPosition<T>(this T[,] matrix, int column, int row)
        {
            if (row > matrix.GetLength(0) - 1 || column > matrix.GetLength(1) - 1)
            {
                throw new Exception($"Элемента с позицией (x: {column}, y: {row}) не существует!");
            }

            return matrix[row, column];
        }

        public static void PrintElementByPosition<T>(this T[,] matrix, int column, int row)
        {
            try
            {
                T el = matrix.GetByPosition(column, row);
                Console.WriteLine("Вы выбрали элемент со значением " + el);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
