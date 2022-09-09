using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class HomeworkNine
    {
        /// <summary>
        /// Задача 64: Задайте значения M и N.Напишите программу, которая найдет сумму чисел от M до N.
        /// M = 1; N = 5. -> 15
        /// M = 4; N = 8. -> 30
        /// </summary>
        public void Task64()
        {
            Console.WriteLine(RecursionSum(1, 5));
            Console.WriteLine(RecursionSum(4, 8));
        }

        private static int RecursionSum(int m, int n)
        {
            int sum = 0;
            if (m <= n)
            {
                sum += m; 
                sum += RecursionSum(++m, n);
            }
            
            return sum;
        }

        /// <summary>
        /// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        /// m = 2, n = 3 -> A(m, n) = 9
        /// A(0,n) = n+1
        /// A(m,0) = A(m-1,1)
        /// A(m, n) = A(m-1, A(m, n-1))
        /// </summary>
        public void Task65()
        {
            Console.WriteLine(AkkermanFunc(0, 0));
            Console.WriteLine(AkkermanFunc(1, 0));
            Console.WriteLine(AkkermanFunc(0, 1));
            Console.WriteLine(AkkermanFunc(2, 3));
            Console.WriteLine(AkkermanFunc(3, 3));
            Console.WriteLine(AkkermanFunc(3, 7));
        }

        public static int AkkermanFunc(int m, int n)
        {
            if (m < 0 || n < 0)
            {
                Console.WriteLine("Числа не могут быть отрицательными!");
                return -1;
            }

            int result = 0;

            if (m == 0)
            {
                result += n+1;
            } else if (n == 0)
            {
                result += AkkermanFunc(m - 1, 1);
            } else if (m > 0)
            {
                result += AkkermanFunc(m-1, AkkermanFunc(m, n-1));
            }
            return result;
        }

        /// <summary>
        /// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
        /// A = 3; B = 5 -> 243 (3⁵)
        /// A = 2; B = 3 -> 8
        /// </summary>
        public void Task69()
        {
            Console.WriteLine(RecursionPow(3,5));
            Console.WriteLine(RecursionPow(2,3));
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
