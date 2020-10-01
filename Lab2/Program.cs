using System;
using System.IO;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter saveout = Console.Out;
            TextReader savein = Console.In;
            var newout = new StreamWriter(@"output.txt");
            var newin = new StreamReader(@"input.txt");
            Console.SetOut(newout);
            Console.SetIn(newin);

            double a, b, c;
            double s, p;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            p = (a + b + c) / 2;
            if ((p < 0) || ( p * (p - a) * (p - b) * (p - c) < 0))
            Console.WriteLine("ERROR");
            else
            {
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine(String.Format("{0:0.000}", s));
            }
            Console.SetOut(saveout); newout.Close();
            Console.SetIn(savein); newin.Close();
        }
    }
}
