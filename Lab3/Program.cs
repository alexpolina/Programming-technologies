
using System;
using System.IO;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int t = 0, N = 1;
            double X = 0, Y = 0, j = 0;
            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());

            int i = 1, step = 1;
            double znam = 1, chisl;

            if (t == 0)
            {
                for (i = 1; i <= N; i++)
                {
                    step = i*2;
                    znam = (step-1) * (step + 1);
                    if (i % 2 == 1)
                        chisl = - Math.Pow(Math.Sin(Math.Pow(Y, step/2)), step + 1);
                    else
                        chisl = Math.Pow(Math.Sin(Math.Pow(X, step/2)), step + 1);
                    j += chisl / znam;
                }
            }

            if (t == 1)
            {
                i = 1;
                while (i <= N)
                {
                    step = i * 2;
                    znam = (step - 1) * (step + 1);
                    if (i % 2 == 1)
                        chisl = -Math.Pow(Math.Sin(Math.Pow(Y, step / 2)), step + 1);
                    else
                        chisl = Math.Pow(Math.Sin(Math.Pow(X, step / 2)), step + 1);
                    j += chisl / znam;
                    i++;

                }
            }

            if (t == 2)
            {
                i = 1;
                do
                {
                    step = i * 2;
                    znam = (step - 1) * (step + 1);
                    if (i % 2 == 1)
                        chisl = -Math.Pow(Math.Sin(Math.Pow(Y, step / 2)), step + 1);
                    else
                        chisl = Math.Pow(Math.Sin(Math.Pow(X, step / 2)), step + 1);
                    j += chisl / znam;
                } while (i <= N);

            }
            Console.WriteLine(String.Format("{0:0.0000}", j));
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();



        }
    }
}
