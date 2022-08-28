using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class Seminar8Online
    {
        public void Task53()
        {
            int[,] matrix = ArrayHelpers.Create2dArray<int>(5, 5);
            matrix.FillIntRandomNumbers(1, 10);
            matrix.Print();
            Console.WriteLine();
            ReplaceFirstRowWithLast(matrix);
            matrix.Print();
        }

        private static void ReplaceFirstRowWithLast(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                var temp = matrix[0, i];
                matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
                matrix[matrix.GetLength(0) - 1, i] = temp;
            }
        }

        public void Task55()
        {
            int[,] matrix = ArrayHelpers.Create2dArray<int>(5, 5);
            matrix.FillIntRandomNumbers(1, 10);
            matrix.Print();
            Console.WriteLine();
            try
            {
                ReplaceRowWithColumn(matrix);
                matrix.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void ReplaceRowWithColumn(int[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1)) throw new Exception("Матрица не соответсвует условиям для переворота!");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    var temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
        }

        public void Task57()
        {
            int[] data = new int[] { 1,2,3,4,12,31,4,1,2,3,4,12,2,3,1,2,3,12 };
            Console.WriteLine(string.Join("; ", data));
            int[,] uniqueNumbers = new int[data.Length, 2];
            for (int i = 0; i < data.Length; i++)
            {
                FindUnique(i, data[i], uniqueNumbers);
            }
            
            uniqueNumbers.Print();
            Console.WriteLine();


            int[,] data2 = ArrayHelpers.Create2dArray<int>();
            data2.FillIntRandomNumbers(1, 30);
            data2.Print();
            int[,] uniqueNumbers2 = ArrayHelpers.Create2dArray<int>(data2.GetLength(0) * data2.GetLength(1), 2);

            for (int i = 0; i < data2.GetLength(0); i++)
            {
                for (int j = 0; j < data2.GetLength(1); j++)
                {
                    FindUnique(i+j, data2[i, j], uniqueNumbers2);
                }
            }

            uniqueNumbers2.Print();
        }

        private static void FindUnique(int position, int data, int[,] uniqueArray)
        {
            int isExistPosition = uniqueArray.IsExistInFirstColumn(data);
            if (isExistPosition >= 0) uniqueArray.IncrementValue(isExistPosition);
            else uniqueArray.AddValue(position, data);
        }
    }
}
