using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class Seminar9Online
    {
        /// <summary>
        /// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
        ///  N = 5 -> "1, 2, 3, 4, 5"
        /// N = 6 -> "1, 2, 3, 4, 5, 6"
        /// Задача 65: Задайте значения M и N.Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
        /// M = 1; N = 5 -> "1, 2, 3, 4, 5"
        /// M = 4; N = 8 -> "4, 6, 7, 8"
        /// </summary>
        public void Task63And65()
        {
            Recursion(5);
            Console.WriteLine();
            Recursion(6);
            Console.WriteLine();
            Recursion(8,4);
        }

        private static void Recursion(int n, int m = 1)
        {
            if (m <= n)
            {
                Console.Write(m + " ");
                Recursion(n, m + 1);
            }
        }

        public void Task67()
        {
            Console.WriteLine(RecursionSum(21231));
        }

        private static int RecursionSum(int n) {
            int sum = 0;
            if (n > 0)
            {
                sum += n % 10;
                sum += RecursionSum(n / 10);
            }
            return sum;
        }

        public void Task69()
        {
            Console.WriteLine(RecursionPow(3,5));
            Console.WriteLine(RecursionPow(3,5));
        }

        private static int RecursionPow(int number, int power)
        {
            int result = 1;
            if (power > 0)
            {
                result = number * RecursionPow(number, power - 1);
            }
            return result;
        }
    }
}
