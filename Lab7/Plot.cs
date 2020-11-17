using System;

namespace Lab7
{
    class Plot
    {
        private double a, b;

        public Plot()
        {
        }

        public Plot(double pA, double pB)
        {
            a = pA; b = pB;
        }

        public static Plot CreatePlotFromFile()
        {
            double aa = Convert.ToDouble(Console.ReadLine());
            double bb = Convert.ToDouble(Console.ReadLine());
            return new Plot(aa, bb);
        }

        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
        }

        public double GetIntegral()
        {
            double result;
            result = (b * b / 2) - (a * a / 2);
            return result;
        }

        public double GetLength()
        {
            double length;
            length = Math.Sqrt(Math.Pow(b - a, 2) + Math.Pow(a - b, 2));
            return length;
        }

        public void Info()
        {
            Console.WriteLine("График функции y = x");
            Console.WriteLine(string.Format("Точки a = {0:0.00}, b = {1:0.00}", a, b));
            Console.WriteLine(string.Format("Опредленный интеграл от a до b равен {0:0.00}", this.GetIntegral()));
            Console.WriteLine(string.Format("Расстояние между точками (a, y(a)) и (b, y(b)) равно {0:0.00}", this.GetLength()));
            Console.WriteLine();
        }

        public void Info(ConsoleColor fg, ConsoleColor bgc)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bgc;
            Console.Clear();
            Info();
        }
    }
}