using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{

    public class HomeWorkEight
    {
        /// <summary>
        /// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        /// Например, задан массив:
        /// 1 4 7 2
        /// 5 9 2 3
        /// 8 4 2 4
        /// В итоге получается вот такой массив:
        /// 7 4 2 1
        /// 9 5 3 2
        /// 8 4 4 2
        /// </summary>
        public void Task54()
        {
            int[,] matrix = ArrayHelpers.Create2dArray<int>();
            matrix.FillIntRandomNumbers(1, 10);
            matrix.Print();
            Console.WriteLine();
            SortInsideRow(matrix);
            matrix.Print();

        }
        private static void SortInsideRow(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = matrix.GetLength(1)-1; k > j; k--)
                    {
                        
                        if (matrix[i,k] > matrix[i, j])
                        {
                            var temp = matrix[i, j];
                            matrix[i, j] = matrix[i, k];
                            matrix[i, k] = temp;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        /// Например, задан массив:
        /// 1 4 7 2
        /// 5 9 2 3
        /// 8 4 2 4
        /// 5 2 6 7
        /// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
        /// </summary>
        public void Task56()
        {
            int[,] matrix = ArrayHelpers.Create2dArray<int>(4, 4);
            matrix.FillIntRandomNumbers(1, 10);
            matrix.Print();
            int rowIndex = GetRowIndexWithSmallestSum(matrix);
            Console.WriteLine($"Наименьшая сумма чисел в : {rowIndex + 1} строке");

        }

        private static int GetRowIndexWithSmallestSum(int[,] matrix)
        {
            int targetRowIndex = 0;
            int sumOfRowDigits = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int tempSumOfRowDigits = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    tempSumOfRowDigits += matrix[i, j];
                }

                if (sumOfRowDigits == 0 || tempSumOfRowDigits < sumOfRowDigits)
                {
                    sumOfRowDigits = tempSumOfRowDigits;
                    targetRowIndex = i;
                }
            }

            return targetRowIndex;
        }


        /// <summary>
        /// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
        /// Например, даны 2 матрицы:
        /// 2 4 | 3 4
        /// 3 2 | 3 3
        /// Результирующая матрица будет:
        /// 18 20
        /// 15 18
        /// </summary>
        public void Task58()
        {
            int[,] matrixA = ArrayHelpers.Create2dArray<int>(2, 4);
            matrixA.FillIntRandomNumbers(-10, 11);
            Console.WriteLine("Matrix A");
            matrixA.Print();

            int[,] matrixB = ArrayHelpers.Create2dArray<int>(3, 3);
            matrixB.FillIntRandomNumbers(-10, 11);
            Console.WriteLine("Matrix B");
            matrixB.Print();

            int[,] result = MultiplyingMatrix(matrixA, matrixB);
            Console.WriteLine("Result:");
            result.Print();
        }
        private static int[,] MultiplyingMatrix(int[,] matrixA, int[,] matrixB) 
        {
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                Console.WriteLine("Матрицы не удовлетворяют условию умножения, количество столбцов матрицы А не равно количеству строк матрицы B.");
                return new int[,] { };
            }

            int[,] resultMatrix = ArrayHelpers.Create2dArray<int>(matrixA.GetLength(0), matrixA.GetLength(1));

            for (int k = 0; k < matrixB.GetLength(1); k++)
            {
                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    int tempSumOfMultiplying = 0;
                    for (int j = 0; j < matrixA.GetLength(1); j++)
                    {
                        tempSumOfMultiplying += matrixA[i, j] * matrixB[j, k];
                    }
                    resultMatrix[i,k] = tempSumOfMultiplying;
                }
            }

            return resultMatrix;
        }


        /// <summary>
        /// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        /// Массив размером 2 x 2 x 2
        /// 66(0,0,0) 25(0,1,0)
        /// 34(1,0,0) 41(1,1,0)
        /// 27(0,0,1) 90(0,1,1)
        /// 26(1,0,1) 55(1,1,1)
        /// </summary>
        public void Task60()
        {
            int[,,] cube = ArrayHelpers.Create3dArray<int>(2,2,2);
            cube.FillIntRandomNumbers(1, 10);
            cube.FillUniqueRandomNumbers(10, 100);
            cube.Print();
        }


        /// <summary>
        /// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
        /// Например, на выходе получается вот такой массив:
        /// 01 02 03 04
        /// 12 13 14 05
        /// 11 16 15 06
        /// 10 09 08 07
        /// </summary>
        public void Task62()
        {
            int[,] matrix = ArrayHelpers.Create2dArray<int>(8, 8);

            FillBySpiral(matrix);

            matrix.Print(' ', '\n', el => string.Format("{0:D2}", el));
        }

        private static void FillBySpiral(int[,] matrix)
        {
            int tempRowIndx = 0;
            int tempColIndx = 0;

            var value = 0;

            while (value < matrix.Length)
            {
                // Go Right
                for (int colIndx = tempColIndx; colIndx < matrix.GetLength(1); colIndx++)
                {
                    if (matrix[tempRowIndx, colIndx] > 0)
                    {
                        break;
                    }

                    matrix[tempRowIndx, colIndx] = ++value;
                    tempColIndx = colIndx;
                }
                tempRowIndx++;

                // Go Down
                for (int rowIndx = tempRowIndx; rowIndx < matrix.GetLength(0); rowIndx++)
                {
                    if (matrix[rowIndx, tempColIndx] > 0)
                    {
                        break;
                    }

                    matrix[rowIndx, tempColIndx] = ++value;
                    tempRowIndx = rowIndx;
                }
                tempColIndx--;

                // Go Left
                for (int colIndx = tempColIndx; colIndx >= 0; colIndx--)
                {
                    if (matrix[tempRowIndx, colIndx] > 0)
                    {
                        break;
                    }

                    matrix[tempRowIndx, colIndx] = ++value;
                    tempColIndx = colIndx;
                }
                tempRowIndx--;

                // Go Up
                for (int rowIndx = tempRowIndx; rowIndx >= 0; rowIndx--)
                {
                    if (matrix[rowIndx, tempColIndx] > 0)
                    {
                        break;
                    }

                    matrix[rowIndx, tempColIndx] = ++value;
                    tempRowIndx = rowIndx;
                }
                tempColIndx++;
            }
        }


        /// <summary>
        /// Задайте двумерный массив из целых чисел. Напишите программу которая удалит строку и столбец на пересечении которых расположен наименьший элемент массива.
        /// </summary>
        public void Task59()
        {
            int[,] matrix = ArrayHelpers.Create2dArray<int>(6, 6);
            matrix.FillIntRandomNumbers(1, 100);
            matrix.Print();
            Console.WriteLine();
            int[] indexOfMinPosition = matrix.IndexOfMin();
            Console.WriteLine("Min number is " + matrix[indexOfMinPosition[0], indexOfMinPosition[1]]);
            Console.WriteLine();
            DeleteRowAndColumnByPositionOfMin(indexOfMinPosition, matrix);
            matrix.Print(' ', '\n', el => string.Format("{0:D2}", el));
            Console.WriteLine();
            int[,] newMatrix = DeleteRowAndColumnByPositionOfMin2(indexOfMinPosition, matrix);
            newMatrix.Print(' ', '\n', el => string.Format("{0:D2}", el));
        }
        private static void DeleteRowAndColumnByPositionOfMin(int[] position, int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (position[0] == i || position[1] == j)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }
        private static int[,] DeleteRowAndColumnByPositionOfMin2(int[] position, int[,] matrix)
        {
            int[,] newMatrix = ArrayHelpers.Create2dArray<int>(matrix.GetLength(0) - 1, matrix.GetLength(1) - 1);
            int newRowIndx = 0;
            int newColIndx = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (position[0] == i)
                {
                    continue;
                }

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (position[1] == j)
                    {
                        continue;
                    }

                    newMatrix[newRowIndx, newColIndx] = matrix[i, j];
                    newColIndx++;
                }
                newColIndx = 0;

                newRowIndx++;
            }
            return newMatrix;
        }

        /// <summary>
        /// Вывести первые N строк прямоугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.
        /// </summary>
        public void Task61()
        {
            int[,] matrix = ArrayHelpers.Create2dArray<int>(11, 19);
            DrawPascalTriangle(matrix);
            Console.WriteLine();
            
        }

        private static void DrawPascalTriangle(int[,] matrix)
        {
            int center = (matrix.GetLength(1)-1) / 2;
            if (center+1 > matrix.GetLength(0))
            {
                Console.WriteLine("Не достаточно строк для отрисовки");
                return;
            }
            for (int i = 0; i < center+1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0 && j == center)
                    {
                        matrix[i, j] = 1;
                    } else if (i > 0 && (j == center - i || j == center + i)) 
                    {
                        matrix[i, j] = 1;
                    } else if (i > 1 && j >= 1 && j <= matrix.GetLength(1)-2 
                        && (matrix[i - 1, j - 1] > 0 || matrix[i - 1, j + 1] > 0))
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j + 1];
                    }

                    Console.Write($"{(matrix[i, j] > 0 ? matrix[i, j] : " "),3}");
                    
                }
                Console.WriteLine();
            }
        }


        private static void PascalTriangle(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j || j == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 0;
                    }
                    else if (i != j)
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
                    }

                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
