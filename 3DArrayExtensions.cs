using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public static class ThreeDArrayExtensions
    {
        public static void FillIntRandomNumbers(this int[,,] cube, int min, int max)
        {
            var randomInstance = new Random();
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        cube[i, j, k] = randomInstance.Next(min, max);
                    }
                }
            }
        }
        public static void FillUniqueRandomNumbers(this int[,,] cube, int min, int max)
        {
            if (cube.Length > max - min)
            {
                Console.WriteLine("Не получится сгенерировать уникальные значения! Увеличьте диапазон случайных чисел!");
            }
            var randomInstance = new Random();
            int[] uniqueNumbers = new int[cube.Length];
            int lastUniqueNumberIndex = 0;
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        int random = randomInstance.Next(min, max);
                        while (Array.IndexOf(uniqueNumbers, random) > -1)
                        {
                            random = randomInstance.Next(min, max);
                        }

                        cube[i, j, k] = random;

                        uniqueNumbers[lastUniqueNumberIndex] = random;
                        lastUniqueNumberIndex++;
                    }
                }
            }
        }
        public static void Print<T>(this T[,,] cube, char delimiterCollumn, char delimeterRow, Func<T, string>? formatFunc)
        {
            for (int i = 0; i < cube.GetLength(2); i++)
            {
                for (int j = 0; j < cube.GetLength(0); j++)
                {
                    for (int k = 0; k < cube.GetLength(1); k++)
                    {
                        Console.Write($"[{j},{k},{i}] = ");
                        Console.Write(formatFunc == null ? cube[i, j, k] : formatFunc(cube[i, j, k]));
                        Console.Write(delimiterCollumn.ToString());
                    }
                    Console.Write(delimeterRow.ToString());
                }
            }
        }

        public static void Print<T>(this T[,,] cube)
        {
            cube.Print(' ', '\n', null);
        }

        public static int GetSize<T>(this T[,,] cube)
        {
            int size = 0;
            for (int i = 0; i < cube.Rank; i++)
            {
                size += cube.GetLength(i);
            }
            return size;
        }
    }
}
