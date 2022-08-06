using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class HomeWorkOne
    {
        /// <summary>
        /// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        ///
        /// a = 5; b = 7 -> max = 7
        /// a = 2 b = 10 -> max = 10
        /// a = -9 b = -3 -> max = -3
        /// </summary>
        public void TaskTwo()
        {
            Console.WriteLine("Задача 2");
            var firstNumber = ReadInt("Введите первое число");
            var secondNumber = ReadInt("Введите второе число");
            var max = firstNumber < secondNumber ? secondNumber : firstNumber;
            Console.WriteLine($"max = {max}");
        }

        /// <summary>
        /// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        /// 2, 3, 7 -> 7
        /// 44 5 78 -> 78
        /// 22 3 9 -> 22
        /// </summary>
        public void TaskFour()
        {
            Console.WriteLine("Задача 4");
            var input = ReadSequenseOfInt("Введите последовательность чисел, например 2, 3, 7");
            Console.WriteLine($"Максимальное число последовательности: {input.Max()}");
        }

        /// <summary>
        /// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        /// 4 -> да
        /// -3 -> нет
        /// 7 -> нет
        /// </summary>
        public void TaskSix()
        {
            Console.WriteLine("Задача 6");
            var input = ReadInt("Введите целое число");

            if (input % 2 == 0)
            {
                Console.WriteLine("Да");
            } else
            {
                Console.WriteLine("Нет");
            }
        }

        /// <summary>
        /// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
        /// 5 -> 2, 4
        /// 8 -> 2, 4, 6, 8
        /// </summary>
        public void TaskEight()
        {
            Console.WriteLine("Задача 8");
            var input = ReadInt("Введите целое число");
            for (int i = 1; i <= input; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i}{(i+1 < input ? ", " : "")}");
                }
            }

        }

        private static int ReadInt(string introMessage, string errorMessage)
        {
            int result;
            Console.WriteLine(introMessage);
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine(errorMessage);
                Console.WriteLine("Повторите попытку");
            }
            return result;
        }

        private static int ReadInt(string introMessage)
        {
            return ReadInt(introMessage, "Вы ввели не целое число или не числов вовсе.");
        }

        private static int[] ReadSequenseOfInt(string introMessage, string errorMessage)
        {
            Console.WriteLine(introMessage);
            while (true)
            {
                var input = Console.ReadLine();
                try
                {
                    var result = input.Split(' ', ',').Select(i => int.Parse(i.Trim())).ToArray();
                    return result;
                } catch
                {
                    Console.WriteLine(errorMessage);
                    Console.WriteLine("Повторите попытку!");
                }
            }
            
        }

        private static int[] ReadSequenseOfInt(string introMessage)
        {
            return ReadSequenseOfInt(introMessage, "Вы ввели ошибочные числа!");
        }
    }
}
