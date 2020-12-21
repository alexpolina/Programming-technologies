using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab11
{
    class Program
    {

        static void Main(string[] args)
        {
            StreamReader f_in = new StreamReader("lr11_01.csv");
#if !DEBUG
            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"lab11output.txt");
            Console.SetOut(new_out);
#endif

            List<Name> all = new List<Name>();

            try
            {
                String line = f_in.ReadLine();
                while ((line = f_in.ReadLine()) != null)
                {
                    all.Add(Name.Create(line));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Всего пользователей: {0}", all.Count);
            foreach (var p in all)
                Console.WriteLine(p);




            Console.WriteLine("----------Количество сотрудников в каждой из 3-х категорий----------\n");

            int bCount = all.FindAll(p => p.CategoryName == Category.бухгалтеры).ToList().Count;
            Console.WriteLine("Количество бухгалтеров: {0}", bCount);

            int eCount = all.FindAll(p => p.CategoryName == Category.инженеры).ToList().Count;
            Console.WriteLine("Количество инженеров: {0}", eCount);

            Console.WriteLine("Количество программистов: {0}", all.Count - (bCount + eCount));

            Console.WriteLine("\n\n");



            Console.WriteLine("----------Суммарный фонд з/п и сумму по каждой категории----------\n");

            float Money_total = (from p in all
                                  select p.Money).Sum();

            float Money_accountants_d = (from p in all
                                       where (p.CategoryName == Category.бухгалтеры) && p.HasDiploma
                                       select p.Money).Sum();

            float Money_accountants = (from p in all
                                       where (p.CategoryName == Category.бухгалтеры) && !p.HasDiploma
                                       select p.Money).Sum();

            float Money_engineers_d = (from p in all
                                       where (p.CategoryName == Category.инженеры) && p.HasDiploma
                                     select p.Money).Sum();

            float Money_engineers = (from p in all
                                     where (p.CategoryName == Category.инженеры) && !p.HasDiploma
                                       select p.Money).Sum();

            float Money_programmers_d = (from p in all
                                         where (p.CategoryName == Category.программисты) && p.HasDiploma
                                       select p.Money).Sum();

            float Money_programmers = (from p in all
                                       where (p.CategoryName == Category.программисты) && !p.HasDiploma
                                         select p.Money).Sum();

            Console.WriteLine("Суммарный фонд з/п: " + Money_total + "$" + "\n");
            Console.WriteLine("Фонд з/п бухгалтеров с дипломом : " + Money_accountants_d + "$" + "\n");
            Console.WriteLine("Фонд з/п инженеров с дипломом: " + Money_engineers_d + "$" + "\n");
            Console.WriteLine("Фонд з/п программистов с дипломом: " + Money_programmers_d + "$" + "\n");
            Console.WriteLine("Фонд з/п бухгалтеров без диплома: " + Money_accountants + "$" + "\n");
            Console.WriteLine("Фонд з/п инженеров без диплома: " + Money_engineers + "$" + "\n");
            Console.WriteLine("Фонд з/п программистов без диплома: " + Money_programmers + "$" + "\n");

            Console.WriteLine("\n\n");



            Console.WriteLine("----------Количество сотрудников с дипломом----------\n");

            int Count_yes = 0, Count_no = 0;
            for (int i = 0; i< all.Count; i++)
            {
                if (all[i].HasDiploma) Count_yes++;
                else Count_no++;
            }
            Console.WriteLine("Количество сотрудников с дипломом: {0}, Количество сотрудников без диплома: {1}", Count_yes, Count_no);
            Console.WriteLine("\n\n\n");



            Console.WriteLine("----------Максимальную зарплату среди сотрудников без диплома----------\n");

            float aMoneyMax = (from p in all
                                       where (p.CategoryName == Category.бухгалтеры) && !p.HasDiploma
                                       select p.Money).Max();
            float eMoneyMax = (from p in all
                              where (p.CategoryName == Category.инженеры) && !p.HasDiploma
                              select p.Money).Max();
            float pMoneyMax = (from p in all
                              where (p.CategoryName == Category.программисты) && !p.HasDiploma
                              select p.Money).Max();

            if (aMoneyMax > eMoneyMax && aMoneyMax > pMoneyMax)
                Console.WriteLine("Максимальная зарплата среди сотрудников без диплома: " + aMoneyMax + "$");
            else if (eMoneyMax > pMoneyMax)
                Console.WriteLine("Максимальная зарплата среди сотрудников без диплома: " + eMoneyMax + "$");
            else
                Console.WriteLine("Максимальная зарплата среди сотрудников без диплома: " + pMoneyMax + "$");


#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
#endif
        }
    }
}