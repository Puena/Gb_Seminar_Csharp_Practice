using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_seminar
{
    public class ReadUtils
    {
        public static int ReadInt(string introMessage, string errorMessage)
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

        public static int ReadInt(string introMessage)
        {
            return ReadInt(introMessage, "Вы ввели не целое число или не числов вовсе.");
        }

        public static int[] ReadSequenseOfInt(string introMessage, string errorMessage)
        {
            Console.WriteLine(introMessage);
            while (true)
            {
                var input = Console.ReadLine();
                try
                {
                    var result = input.Split(' ', ',').Select(i => int.Parse(i.Trim())).ToArray();
                    return result;
                }
                catch
                {
                    Console.WriteLine(errorMessage);
                    Console.WriteLine("Повторите попытку!");
                }
            }

        }

        public static int[] ReadSequenseOfInt(string introMessage)
        {
            return ReadSequenseOfInt(introMessage, "Вы ввели ошибочные числа!");
        }
    }
}
