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

        public static void Print(this int[,] matrix, char delimiterCollumn, char delimeterRow)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + delimiterCollumn.ToString());
                }
                Console.Write(delimeterRow.ToString());
            }
        }
    }
}
