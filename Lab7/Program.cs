using System;
using System.IO;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"plot-output.txt");
            var new_in = new StreamReader(@"plot-input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in); 
#endif
            Plot p1, p2;
#if DEBUG
            p1 = new Plot(8, 23);
            p1.Info(ConsoleColor.Red, ConsoleColor.White);
#endif

#if !DEBUG
            p1 = Plot.CreatePlotFromFile();
            p1.Info();
            p2 = new Plot(5, 11);
            p2.Info();
#endif

#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
