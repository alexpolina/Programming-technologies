using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите количество строк:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int m = Convert.ToInt32(Console.ReadLine());
            TextWriter saveout = Console.Out;
            var new_out = new StreamWriter("input.txt");
            Console.SetOut(new_out);


            int i, j;
            int[,] arr = new int[n, m];
            Random r = new Random();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(r.Next(-100000, 100000) / 10.00);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.SetOut(saveout); new_out.Close();

            TextReader save_in = Console.In;
            TextWriter save_out = Console.Out;
            var Newout = new StreamWriter("output.txt");
            var Newin = new StreamReader("input.txt");
            Console.SetOut(Newout);
            Console.SetIn(Newin);

            Console.WriteLine("***Исходная матрица***");
            Console.WriteLine();

            int[,] mas = new int[n, m];
            for (i = 0; i < n; i++)
            {
                String str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (j = 0; j < m; j++)
                {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    //вывод матрицы
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Среднее арифметическое каждой строки
            float sa = 0;
            float sum = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                   sum += mas[i, j];
                   sa = 1.0f * sum / n;
                }
                sum = 0;
                Console.WriteLine(string.Format("{0:000000}", "Среднее арифметическое строки равно " + sa));
            }
            Console.WriteLine();

            //Вывод модифицированной матрицы 
            Console.WriteLine("***Модифицированная матрица***");
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (mas[i, j] % 2 == 0)
                        Console.Write("+ ");
                    else
                        Console.Write("- ");
                }
                Console.WriteLine();
            }

            Console.SetOut(save_out); Newout.Close();
            Console.SetIn(save_in); Newin.Close();

        }
    }
}
