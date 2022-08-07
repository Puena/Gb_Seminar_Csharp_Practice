using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class Seminar2Online
    {
        /// <summary>
        /// 1. Напишите программу, которая принимает
        /// на вход трёхзначное число и на выходе
        /// показывает последнюю цифру этого числа.
        /// 456 -> 6
        /// 782 -> 2
        /// 918 -> 8
        /// </summary>
        public void TaskOne()
        {
            Console.WriteLine("Введите трёхзначное число!");
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine($"Последнее число {input % 10}");
        }

        /// <summary>
        /// 2. Напишите программу, которая выводит
        /// случайное число из отрезка[10, 99] и показывает
        /// наибольшую цифру числа.
        /// 78 -> 8
        /// 12-> 2
        /// 85 -> 8
        /// </summary>
        public void TaskTwo()
        {
            Console.WriteLine("Максимальная цифра из числа на отрезке 10..99");
            var segment = new int[] { 10, 99 };
            var randomNumber = new Random().Next(segment[0], segment[1] + 1);
            var firstDigit = randomNumber / 10;
            var secondDigit = randomNumber % 10;
            Console.WriteLine($"Случайное число {randomNumber}");
            Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);
        }

        /// <summary>
        /// 3. Напишите программу, которая будет принимать на
        /// вход два числа и выводить, является ли второе число
        /// кратным первому.Если число 2 не кратно числу 1, то
        /// программа выводит остаток от деление.
        /// 34, 5 -> не кратно, остаток 4
        /// 16, 4 -> кратно
        /// </summary>
        public void TaskThree()
        {
            Console.WriteLine("Кратность числе");
            Console.WriteLine("Введите число");
            var inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите делитель");
            var inputDevider = int.Parse(Console.ReadLine());
            var remainder = inputNumber % inputDevider;
            
            if (remainder == 0)
            {
                Console.WriteLine("Кратно");
            } else
            {
                Console.WriteLine($"не кратно, осток {remainder}");
            }
        }
    }
}
