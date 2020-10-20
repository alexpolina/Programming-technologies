using System;


namespace Lab6
{
    class Ball
    {
        private double r;

        public double GetV() { return 4 / 3 * Math.PI * Math.Pow(r, 3); }

        public double GetD() { return r * 2; }

        public double GetS() { return 4 * Math.PI * Math.Pow(r, 2); }


        public void Info()
        {
            String str =
                "           * *        \n" +
                "       *         *      \n" +
                "     *             *     \n" +
                "    *      ШАР      *     \n" +
                "     *             *     \n" +
                "       *         *      \n" +
                "           * *        \n";
            Console.WriteLine(str);
            Console.WriteLine(string.Format("R = {0:0.00}", r));
            Console.WriteLine(string.Format("D = {0:0.00}", GetD()));
            Console.WriteLine(string.Format("V = {0:0.00}", GetV()));
            Console.WriteLine(string.Format("S = {0:0.00}", GetS()));
        }

        public void Load()
        {
            Console.WriteLine("Введите значение радиуса");
            r = Convert.ToDouble(Console.ReadLine());
        }
    }
}