using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class Seminar7Online
    {
        public void Task46()
        {

            
        }

        /// <summary>
        /// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
        /// m = 3, n = 4.
        /// 0 1 2 3
        /// 1 2 3 4
        /// 2 3 4 5
        /// </summary>
        public void Task48()
        {
            int m = 3, n = 4;
            var arr = Create2DArray(m, n);
            FillArrayTask48(arr);
            arr.Print(' ', '\n');
            
        }

        private int[,] Create2DArray(int rows, int column)
        {
            return new int[rows, column];
        }

        private void FillArrayTask48(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i+j;
                }
            }
        }

        public void Task49And51()
        {
            var arr = new int[10, 10];
            arr.FillIntRandomNumbers(1, 10);
            ChangeOddPowerOftwo(arr);
            arr.Print(' ', '\n');
            ShowMainDiagonal(arr);
        }

        private void ChangeOddPowerOftwo(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i % 2 != 0 && j % 2 != 0)
                    {
                        matrix[i, j] *= matrix[i, j];
                    }
                }
            }
        }

        private void ShowMainDiagonal(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i < matrix.GetLength(1))
                {
                    Console.WriteLine(Tabs(i) + matrix[i, i]);
                }
            }
        }

        static string Tabs(int n)
        {
            if (n == 0)
            {
                return "";
            }
            return new string(' ', n*2);
        }
    }
}
