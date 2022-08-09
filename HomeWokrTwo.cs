using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class HomeWokrTwo
    {
        /// <summary>
        /// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        /// 456 -> 5
        /// 782 -> 8
        /// 918 -> 1
        /// </summary>
        public void TaskTen()
        {
            Console.WriteLine("Задача номер 10");
            var input = ReadUtils.ReadInt("Введите трёхзначное число!");
            Console.WriteLine($"Второе число, это {input / 10 % 10}");
        }

        /// <summary>
        /// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        /// 645 -> 5
        /// 78 -> третьей цифры нет
        /// 32679 -> 6
        /// </summary>
        public void TaskThirteen()
        {
            Console.WriteLine("Задача номер 13");
            var input = ReadUtils.ReadInt("Введите число.");

            if (input < 100)
            {
                Console.WriteLine("третей цифры нет.");
                return;
            }

            while (input > 999)
            {
                input /= 10;
            }

            Console.WriteLine($"Третья цифра это: {input % 10}");
        }

        /// <summary>
        /// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        /// 6 -> да
        /// 7 -> да
        /// 1 -> нет
        /// </summary>
        public void TaskFifteen()
        {
            Console.WriteLine("Задача номер 15");
            var input = ReadUtils.ReadInt("Введи цифру соответсвующую дню недели!");

            switch (input)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine(":-( Рабочий день!");
                    break;
                case 6:
                case 7:
                    Console.WriteLine(":-) Выходной день!");
                    break;
                default:
                    Console.WriteLine(":-/ Такого дня недели не существует!");
                    break;
            }
        }
    }
}
