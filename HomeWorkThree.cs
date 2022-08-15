using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class HomeWorkThree
    {
        /// <summary>
        /// Задача 19
        /// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        /// 14212 -> нет
        /// 12821 -> да
        /// 23432 -> да
        /// </summary>
        public void TaskNineteen()
        {
            Console.WriteLine("Задача 19. Полиндром.");
            var input = ReadUtils.ReadInt("Введи целое число.");
            Console.WriteLine(IsPolindrom(input) ? "Да" : "Нет");
            
        }
        private bool IsPolindrom(int num)
        {
            var polindrom = 0;
            var temp = num;
            while (temp > 0)
            {
                polindrom = temp % 10 + polindrom * 10;
                temp /= 10;
            }
            return polindrom == num;
        }

        /// <summary>
        /// Задача 21
        /// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        /// A(3,6,8); B(2,1,-7), -> 15.84
        /// A(7,-5, 0); B(1,-1,9) -> 11.53
        /// </summary>
        public void TaskTwentyOne()
        {
            var a = ReadUtils.ReadSequenseOfDouble("Введите координаты точки А (x,y,z), например: 3, 6, 8");
            var b = ReadUtils.ReadSequenseOfDouble("Введите координаты точки B (x,y,z), например: 2, 1, -7");
            var distance = Distance(a, b);
            Console.WriteLine($"Расстояние между точками a({string.Join(", ", a)}) и b({string.Join(", ", b)}), составляет {distance:f2}");

        }
        private double Distance(double[] pointA, double[] pointB)
        {
            return Math.Sqrt((pointA[0] - pointB[0]) * (pointA[0] - pointB[0])
                            + (pointA[1] - pointB[1]) * (pointA[1] - pointB[1])
                            + (pointA[2] - pointB[2]) * (pointA[2] - pointB[2]));
        }

        /// <summary>
        /// Задача 23
        /// Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
        /// 3 -> 1, 8, 27
        /// 5 -> 1, 8, 27, 64, 125
        /// </summary>
        public void TaskTwentyThree()
        {
            int input = ReadUtils.ReadInt("Введите целое число.");
            var cubes = ComposeCubeString(input);
            Console.WriteLine(cubes);
        }
        private string ComposeCubeString(int input)
        {
            var s = new StringBuilder();
            for (int i = 1; i <= input; i++)
            {
                s.Append(Math.Pow(i, 3));
                // comma
                if (i != input)
                {
                    s.Append(", ");
                }
            }
            return s.ToString();
        }
    }
}
