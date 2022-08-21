using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class HomeworkSix
    {
        /// <summary>
        /// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        /// 0, 7, 8, -2, -2 -> 2
        /// 1, -7, 567, 89, 223-> 3
        /// </summary>
        public void Task41()
        {
            var numbers = ReadUtils.ReadSequenseOfInt("Введите последовательность чисел, например: 1,2,3,4,-5");
            var moreThanZero = numbers.Where(n => n > 0).Count();
            Console.WriteLine($"Вы ввели {moreThanZero} болше 0");
        }

        /// <summary>
        /// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
        /// y = k1x + b1; 
        /// y = k2x + b2;  k1x + b1 - k2x = b2; (k1-k2)x = b2 - b1; x = b2 - b1 / k1 - k2
        /// значения b1, k1, b2 и k2 задаются пользователем.
        /// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
        /// </summary>
        public void Task43()
        {
            double b1 = ReadUtils.ReadDouble("Введите значение для b1");
            double k1 = ReadUtils.ReadDouble("Введите значение для k1");
            double b2 = ReadUtils.ReadDouble("Введите значение для b2");
            double k2 = ReadUtils.ReadDouble("Введите значение для k2");

            double x = (b2 - b1) / (k1 - k2); ;
            double y = k2 * x + b2;

            Console.WriteLine($"Точка пересечения {x} {y}");
        }

        /// <summary>
        /// Дополнительное задание
        /// Задано натуральное число n. Необходимо перевести его в k-ичную систему счисления и найти разность между произведением и суммой его цифр в этой системе счисления.
        /// Например, пусть n = 239, k = 8.Тогда представление числа n в восьмеричной системе счисления — 357, а ответ на задачу равен 3 × 5 × 7 − (3 + 5 + 7) = 90.
        /// </summary>
        public void TaskAdditional()
        {
            int number = ReadUtils.ReadInt("Введите число, например 226");
            int system = ReadUtils.ReadInt("Введите систему счисления");

            string n = Convert.ToString(number, system);
            char[] chars = n.ToCharArray();
            int sumDigitsOfNumber = chars.Select(n => Convert.ToInt32(n.ToString())).Sum();
            int multiplicationDigitsOfNumber = chars.Select(n => Convert.ToInt32(n.ToString())).Aggregate((c, n) => c * n);
            Console.WriteLine($"Число в {system} системе координат это {n}, произведение {multiplicationDigitsOfNumber}, сумма {sumDigitsOfNumber}");
        }
        public void TaskAdditionalV2()
        {
            int number = ReadUtils.ReadInt("Введите число, например 226");
            int system = ReadUtils.ReadInt("Введите систему счисления");

            string n = IntToSystem(number, system);
            var sumDigitsOfNumber = SumOfDigits(n);
            var multiplicationDigitsOfNumber = MultiplyOfDigits(n);
            Console.WriteLine($"Число в {system} системе координат это {n}, произведение {multiplicationDigitsOfNumber}, сумма {sumDigitsOfNumber}");
        }

        private static string IntToSystem(int number, int system)
        {
            string result = string.Empty;
            int reminder;
            while(number > 0)
            {
                reminder = number % system;
                result = reminder.ToString() + result;
                number /= system;
            }
            return result;
        }

        private static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach (var item in number)
            {
                sum += Convert.ToInt32(item.ToString()); 
            }

            return sum;
        }
        private static int MultiplyOfDigits(string number)
        {
            int mult = 1;
            foreach (var item in number)
            {
                mult *= Convert.ToInt32(item.ToString());
            }

            return mult;
        }
    }
}
