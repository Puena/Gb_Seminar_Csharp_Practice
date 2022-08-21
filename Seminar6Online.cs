using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class Seminar6Online
    {
        /// <summary>
        /// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
        /// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
        /// </summary>
        public void Task40()
        {
            int a = ReadUtils.ReadInt("Введите размер стороны a");
            int b = ReadUtils.ReadInt("Введите размер стороны b");
            int c = ReadUtils.ReadInt("Введите размер стороны c");

            if (a > b + c && b > a + c && c > a + b)
            {
                Console.WriteLine("Равен");
            } else
            {
                Console.WriteLine("Неравен");
            }

        }

        /// <summary>
        /// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
        /// 45 -> 101101
        /// 3  -> 11
        /// 2  -> 10
        /// </summary>
        public void Task42()
        {
            int decimalNumber = ReadUtils.ReadInt("Введите целое число для преобразования в двоичное.");
            string binary = ConvertDecimalToBinary(decimalNumber);
            string binary2 = Convert.ToString(decimalNumber, 2);
            string binary3 = ConverFor(decimalNumber);
            Console.WriteLine($"Двоичное число {decimalNumber} это {binary} {binary2} {binary3}");
        }
        private static string ConvertDecimalToBinary(int decimalNumber)
        {
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            return result;
        }

        private static string ConverFor(int decimalNumber)
        {
            int remainder;
            string result = string.Empty;

            for (int i = decimalNumber; i > 0 ; i = i / 2)
            {
                remainder = i % 2;
                result = remainder.ToString() + result;
            }
            return result;
        }

        public void Task44()
        {
            var input = ReadUtils.ReadInt("Введите число фибоначи!");
            var f = fib(input);
            Console.WriteLine("Результат " + f);
        }

        public int fib(int number)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber = 0;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(firstNumber);
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            return firstNumber;
        }


        /// <summary>
        ///  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
        /// </summary>
        public void Task45()
        {
            var arrLength = ReadUtils.ReadInt("Введите длину массива.");
            var userArr = new int[arrLength];
            userArr.FillIntRandomNumbers(-100, 100);
            var copy = CopyArr(userArr);
            Console.WriteLine("Массив скопирован!");
        }

        private static int[] CopyArr(int[] toCopy)
        {
            var newArr = new int[toCopy.Length];
            for (int i = 0; i < toCopy.Length; i++)
            {
                newArr[i] = toCopy[i];
            }
            return newArr;
        }
    }
}
