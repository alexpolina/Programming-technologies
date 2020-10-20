using System;
using System.IO;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"ball_output.txt");
            var new_in = new StreamReader(@"ball_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            Ball b = new Ball();
            b.Load();
            b.Info();

#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}

