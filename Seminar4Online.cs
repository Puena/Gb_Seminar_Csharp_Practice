using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class Seminar4Online
    {
        /// <summary>
        /// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
        /// 456 -> 3
        /// 78 -> 2
        /// 89126 -> 5
        /// </summary>
        /// <param name="n">Enter 32 bit number</param>
        /// <returns>Returns digits count</returns>
        public int Task26(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            int count = 0;
            while (n != 0)
            {
                count++;
                n /= 10;
            }
            return count;
        }

        /// <summary>
        /// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
        // [1,0,1,1,0,1,0,0]

        /// </summary>
        public void Task30()
        {
            const int arraySize = 8;
            var target = new int[arraySize];

            FillRandomNumber(target);
            PrintArray(target);
            PrintArratAlt(target);
        }

        private void FillRandomNumber(int[] arr)
        {
            var randomInstance = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomInstance.Next(0,2);
            }
        }

        private void PrintArray(int[] arr)
        {
            Console.WriteLine($"[{string.Join(",", arr)}]");
        }

        private void PrintArratAlt(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                // comma
                if (i != arr.Length - 1) Console.Write(",");
            }
            Console.WriteLine("]");
        }
    }
}
