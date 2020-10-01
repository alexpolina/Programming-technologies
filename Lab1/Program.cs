using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a_1 = 12;
            int b = 34;
            int a = 5;
            int x = 54;
            int y5 = 67;
            int F;

            F = a_1 + b - a * (x + y5);

            Console.WriteLine("Лабораторная работа №1. Структура консольного приложения ");
            Console.WriteLine("");
            Console.WriteLine("Задание 1");
            Console.WriteLine("Группа: ИНС-б-о-191, 09.03.02 - Информационные системы и технологиии");
            Console.WriteLine("Алексеева Полина Андреевна");
            Console.WriteLine("дата рождения: 12 мая 2001 г.");
            Console.WriteLine("г.Ставрополь");
            Console.WriteLine("любимый предмет - информатика");
            Console.WriteLine("хобби: дизайн, рисование, иностранные языки, книги, йога");
            Console.WriteLine("");
            Console.WriteLine("Задание 2. Вариант 1");
            Console.WriteLine("");
            Console.WriteLine("Выражение: F = a_1 + b - a * (x + y5)");
            Console.WriteLine("Значение переменной а равно {0}", a);
            Console.WriteLine("Значение переменной а_1 равно {0}", a_1);
            Console.WriteLine("Значение переменной b равно {0}", b);
            Console.WriteLine("Значение переменной x равно {0}", x);
            Console.WriteLine("Значение переменной y5 равно {0}", y5);
            Console.WriteLine("Значение выражения F равно {0}", F);
            Console.ReadKey();

        }
    }
}
