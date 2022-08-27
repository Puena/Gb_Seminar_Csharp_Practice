using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class HomeWorkFive
    {
        /// <summary>
        /// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
        /// [345, 897, 568, 234] -> 2
        /// </summary>
        public void Task34()
        {
            var arrayLength = ReadUtils.ReadInt("Укажите количество эллементов в массиве.");
            var arr = new int[arrayLength];
            arr.FillIntRandomNumbers(100, 1000);
            Console.WriteLine("Массив заполнен. " + string.Join(", ", arr));
            Console.WriteLine("Количество четных чисел в массиве: " + arr.CountEvenNumbers());
        }

        /// <summary>
        /// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
        /// [3, 7, 23, 12] -> 19
        /// [-4, -6, 89, 6] -> 0
        /// </summary>
        public void Task36()
        {
            var arrayLength = ReadUtils.ReadInt("Укажите количество эллементов в массиве.");
            var arr = new int[arrayLength];
            arr.FillIntRandomNumbers(-100, 100);
            Console.WriteLine("Массив заполнен. " + string.Join(", ", arr));
            Console.WriteLine("Сумма элементов с нечетным индексом: " + arr.SumOddPositionElements());

        }

        /// <summary>
        /// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
        /// [3, 7, 22, 2, 78] -> 76
        /// </summary>
        public void Task38()
        {
            var arrayLength = ReadUtils.ReadInt("Укажите количество эллементов в массиве.");
            var arr = new int[arrayLength];
            arr.FillIntRandomNumbers(1, 100);
            Console.WriteLine("Массив заполнен. " + string.Join(", ", arr));
            Console.WriteLine("Разница между максимальным и минимальным: " + arr.DiferenceBetweenMaxMin());
        }

        /// <summary>
        /// Условие https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=702(%D0%94%D0%BE%D0%BF%D0%BE%D0%BB%D0%BD%D0%B8%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D0%B5
        /// </summary>
        public void TaskAdditional()
        {
            var arrayLength = ReadUtils.ReadInt("Укажите количество эллементов в массиве.");
            var arr = new int[arrayLength];
            arr.FillIntRandomNumbers(-1000, 1000);
            Console.WriteLine("Массив заполнен. " + string.Join(", ", arr));
            //arr.Reverse();
            arr.ReverseArray();
            Console.WriteLine("Массив перевернут: " + string.Join(", ", arr));
        }
    }

    public static class IntArrayExtensions
    {
        /// <summary>
        /// Fill array with random numbers
        /// </summary>
        /// <param name="min">inclusive</param>
        /// <param name="max">exclusive</param>
        public static void FillIntRandomNumbers(this int[] arr, int min, int max)
        {
            var randomInstance = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomInstance.Next(min, max);
            }
        }

        public static int CountEvenNumbers(this int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) sum++;
            }
            return sum;
        }

        public static int SumOddPositionElements(this int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public static int DiferenceBetweenMaxMin(this int[] arr)
        {
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                var currentElement = arr[i];
                if (currentElement < min)
                {
                    min = currentElement;
                }
                if (currentElement > max)
                {
                    max = currentElement;
                }
            }

            return max - min;
        }

        public static void ReverseArray(this int[] arr)
        {
            var lastPositionIndex = arr.Length - 1;
            for (int i = 0, j = lastPositionIndex; i < j; i++, j--)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
