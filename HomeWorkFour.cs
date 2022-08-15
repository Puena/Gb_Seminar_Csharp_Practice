using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class HomeWorkFour
    {
        /// <summary>
        /// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        /// 3, 5 -> 243 (3⁵)
        /// 2, 4 -> 16
        /// </summary>
        public void TaskTwentyFive()
        {
            Console.WriteLine("Задача 25. Степень числа.");
            var a = ReadUtils.ReadInt("Введите число.");
            var b = ReadUtils.ReadInt("Введите число.");
            var degreeOfb = Math.Pow(a, b);
            Console.WriteLine($"{a} в степени {b}, равно {degreeOfb}");
        }

        /// <summary>
        /// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        /// 452 -> 11
        /// 82 -> 10
        /// 9012 -> 12
        /// </summary>
        public void TaskTwentySeven()
        {
            Console.WriteLine("Задача номер 27. Сумма цифр числа.");
            var input = ReadUtils.ReadInt("Ввдите целое число");
            var sum = CalculateSumOfDigits(input);
            Console.WriteLine($"Сумма цифр числа {input} равна {sum}");
        }
        private int CalculateSumOfDigits(int number)
        {
            int sum = 0;
            int temp = number;
            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            return sum;
        }

        /// <summary>
        /// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
        /// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
        /// 6, 1, 33 -> [6, 1, 33]
        /// </summary>
        public void TaskTwentyNine()
        {
            Console.WriteLine("Задача 29. Задать массив.");
            int[] arr = new int[8];
            var input = ReadUtils.ReadSequenseOfInt("Заполните массив числами. Ноль не отображается. Максимальное количетсво чисел 8. Например: 1,2,5,7,19");
            FillArrayFromInput(arr, input);
            Console.WriteLine($"Вы ввели слудующую последовательность: [{string.Join(", ", arr.Where(e => e != 0).ToArray())}]");
        }
        public void TaskTwentyNineVer2()
        {
            Console.WriteLine("Задача 29. Задать массив.");
            const int maxArraySize = 8;
            var input = ReadUtils.ReadSequenseOfInt("Заполните массив числами. Максимальное количетсво чисел 8. Например: 1,2,5,7,19");
            if (input.Length > maxArraySize) input = input.Take(maxArraySize).ToArray();
            Console.WriteLine($"Вы ввели слудующую последовательность: [{string.Join(", ", input)}]");
        }
        private void FillArrayFromInput(int[] target, int[] input)
        {

            for (int i = 0; i < target.Length; i++)
            {
                if (input.Length > i) target[i] = input[i];
            }

            if (input.Length > 8)
            {
                Console.WriteLine("Вы ввели больше 8 чисел. Будут учтены только 8 введеных цифр");
            }
        }
    }
}
