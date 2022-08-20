using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{

    public class Seminar5Online
    {
            /// <summary>
    /// Решение в группах задач:
    /// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
    /// [-4, -8, 8, 2] -> [4, 8, -8, -2]
    /// </summary>
        public void Task32()
        {
            var arraySize = ReadUtils.ReadInt("Какое количество случайных элементов необходиимо?");
            var minNumber = ReadUtils.ReadInt("Введите нижнее значение для диапозона случайных числе.");
            var maxNumber = ReadUtils.ReadInt("Введите верхнее значение для диапозона случайных числе.");
            
            var arr = new int[arraySize];
            Console.WriteLine("Ваш массив случаных числе: " + string.Join(", ", arr));
            FillArrayRandomIntNumners(arr, minNumber, maxNumber+1);
            ChangeSignOfNumber(arr);
            Console.WriteLine("Измененный массив случайных числе: " + string.Join(", ", arr));
        }
        private static void FillArrayRandomIntNumners(int[] arr, int min, int max)
        {
            var randomInstance = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomInstance.Next(min, max);
            }
        }

        private static void ChangeSignOfNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= -arr[i];
            }
        }

        /// <summary>
        /// Задача 33: Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.
        /// 4; массив[6, 7, 19, 345, 3] -> нет
        /// -3; массив[6, 7, 19, 345, 3] -> да
        /// </summary>
        public void Task33()
        {
            var arraySize = ReadUtils.ReadInt("Какое количество случайных элементов необходиимо?");
            var minNumber = ReadUtils.ReadInt("Введите нижнее значение для диапозона случайных числе.");
            var maxNumber = ReadUtils.ReadInt("Введите верхнее значение для диапозона случайных числе.");
            var userNumber = ReadUtils.ReadInt("Проверьте есть ли число в созданном массиве.");

            var arr = new int[arraySize];
            FillArrayRandomIntNumners(arr, minNumber, maxNumber);

            Console.WriteLine($"Число {userNumber} {(arr.isExist(userNumber) ? "Присутсвует" : "Нет")} в массиве.");
            Console.WriteLine("Массив чисел: " + string.Join(", ", arr));
        }
        
        /// <summary>
        /// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
        /// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
        /// [5, 18, 123, 6, 2] -> 1
        /// [1, 2, 3, 6, 2] -> 0
        /// [10, 11, 12, 13, 14] -> 5
        /// </summary>
        public void Task35()
        {
            var arr = new int[123];
            FillArrayRandomIntNumners(arr, 0, 123);
            Console.WriteLine("Сумма элементов в диапозоне от 10 до 99 включительно " + SumBetween10And99(arr));
        }
        private static int SumBetween10And99(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 10 && arr[i] <= 99) sum++; 
            }
            return sum;
        }

        /// <summary>
        /// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
        /// [1 2 3 4 5] -> 5 8 3
        /// [6 7 3 6] -> 36 21
        /// </summary>
        public void Task37()
        {
            var arraySize = ReadUtils.ReadInt("Какое количество случайных элементов необходиимо?");
            var minNumber = ReadUtils.ReadInt("Введите нижнее значение для диапозона случайных числе.");
            var maxNumber = ReadUtils.ReadInt("Введите верхнее значение для диапозона случайных числе.");

            var arr = new int[arraySize];
            FillArrayRandomIntNumners(arr, minNumber, maxNumber);
            var m = LogMultiplyCouples(arr);
            Console.WriteLine("Произведение крайних чисел: " + string.Join(", ", m));
            Console.WriteLine(string.Join(", ", arr));
        }
        private static int[] LogMultiplyCouples(int[] arr)
        {
            var res = new int[arr.Length / 2 + arr.Length % 2];
            for (int i = 0, k = arr.Length-1; i <= k; i++, k--)
            {
                var left = arr[i];
                var right = arr[k];
                    
                if (i == k ) res[i] = left;
                else res[i] = right * left;
            }
            return res;
        }
    }
}

public static class ArrayExtensions
{
    public static bool isExist(this int[] arr, int number)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number) return true;
        }
        return false;
    }
}
