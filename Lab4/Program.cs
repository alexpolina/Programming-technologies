using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            TextWriter saveout = Console.Out;
            var new_out = new StreamWriter("input.txt");
            Console.SetOut(new_out);
            Console.WriteLine(n);
            Random r = new Random();
            int a = 0;
            int i;
            for (i = 0; i < n; i++)
            {
                a = Convert.ToInt32(r.Next(0, 100000) / 10.00);
                Console.Write(a + " ");
            }

             Console.SetOut(saveout); new_out.Close();
            TextReader save_in = Console.In;
            TextWriter save_out = Console.Out;
            var Newout = new StreamWriter("output.txt");
            var Newin = new StreamReader("input.txt");
            Console.SetOut(Newout);
            Console.SetIn(Newin);

            int N = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            string[] str_elem = str.Split(' ');

            int[] mas = new int[N];
            for (i = 0; i < N; i++)
            {
                mas[i] = Convert.ToInt32(str_elem[i]);
            }

            //Среднее арифметическое
            float sa = 0;
            int s = 0;
            for (i = 0; i < N; i++)
            {
                s += mas[i];
            }
            sa = 1.0f * s / N;

            Console.WriteLine(string.Format("{0:000000}", "Среднее арифметическое равно " + sa));

            //Количество чисел, больших среднего арифметического равно
            int l = 0;
            for (i = 0; i < N; i++)
            {
                if (mas[i] > sa)
                    l += 1;
            }
            Console.WriteLine("Количество чисел, больших среднего арифметического равно " + l);

            //Сумма чисел, меньших среднего арифметического
            int sum = 0;
            for (i = 0; i < N; i++)
            {
                if (mas[i] < sa)
                    sum += mas[i];
            }
            Console.WriteLine("Сумма чисел, меньших среднего арифметического равна " + sum);

            //Максимальное число равно
            float max = mas[0];
            for (i = 0; i < N; i++)
            {
                if (mas[i] > max)
                    max = mas[i];
            }
            Console.WriteLine("Максимальное число равно " + max);

            Console.SetOut(save_out); Newout.Close();
            Console.SetIn(save_in); Newin.Close();
        }

    }
}

