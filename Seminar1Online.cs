using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class Seminar1Online
    {

        public void TaskOne()
        {
            //1.Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
            //a = 5, b = 25->да 
            //a = 2, b = 10->нет 
            //a = 9, b = -3->нет 
            //a = -3, b = 9->да
            Console.Clear();
            Console.WriteLine("Программа для проверка квадрата числа.");
            Console.WriteLine("Введите число которое необходимо возвести в квадрат");
            var inputNumber = double.Parse(Console.ReadLine());
            var _internalInputNumberSqrt = Math.Pow(inputNumber, 2);
            Console.WriteLine("Приянто!");

            Console.WriteLine($"Теперь введите квадрат этого числа {inputNumber}");
            var inputSqrt = double.Parse(Console.ReadLine());
            Console.WriteLine("Принято!");

            if (_internalInputNumberSqrt == inputSqrt)
            {
                Console.WriteLine($"Всё верно! {inputSqrt} является квадратом числа {inputNumber}");
            }
            else
            {
                Console.WriteLine($"Ошибочка! {inputSqrt} не является квадратом числа {inputNumber}");
            }
        }

        public void TaskTwo()
        {

            //3.Напишите программу, которая будет выдавать название дня недели по заданному номеру.
            //       3 -> Среда
            //       5 -> Пятница

            Console.Clear();
            Console.WriteLine("Программа для выдачи дней недели по номеру!");
            Console.WriteLine("Введите номе дня недели, от 1 до 7");
            var inputDayNumber = int.Parse(Console.ReadLine());

            switch (inputDayNumber)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Такого дня недели не существует!");
                    break;
            }

        }
    }
}
