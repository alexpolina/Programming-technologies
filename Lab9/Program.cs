using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public interface IChangable
    {
        void Growth(double pValue);
        void Fall(double pValue);
    }

    public interface IConvert
    {
        void ConvertToGallon();
        void ConvertToOunce();
        void ConvertToLitre();
    }

    public interface IDrawable
    {
        string Name { get; set; }
        void DrawObject();
    }

    public class Автомобиль : IChangable, IDrawable
    {
        public Автомобиль(string pType, double pEngine)
        {
            Type = pType;
            Engine = pEngine;
        }
        private string Type;
        private double Engine;

        public void Growth(double pValue)
        {
            Engine *= 1.5 * pValue;
        }

        public void Fall(double pValue)
        {
            Engine *= 0.5 * pValue;
        }

        public string Name
        {
            get
            {
                return Type + "Автомобиль, объем двигателя =" + Engine.ToString();
            }
            set
            {
                Type = value;
            }
        }

        public void DrawObject()
        {
            Console.WriteLine
                 ("   .,==========o00o         \n" +
                   "  //___l__,| ____ |,___    \n" +
                   "l_ -— |____l —— []lllllll[]\n" +
                   "  _(o)_) ___(o)_)--o -)_)  \n"

                );
            Console.WriteLine(Name);
        }
    }
    public class Грузовик : IChangable, IDrawable
    {
        public Грузовик(string pType, double pEngine)
        {
            Type = pType;
            Engine = pEngine;
        }
        private string Type;
        private double Engine;

        public void Growth(double pValue)
        {
            Engine *= 1.5 * pValue;
        }

        public void Fall(double pValue)
        {
            Engine *= 0.5 * pValue;
        }

        public string Name
        {
            get
            {
                return Type + ", объем двигателя =" + Engine.ToString();
            }
            set
            {
                Type = value;
            }
        }
        public void DrawObject()
        {
            Console.WriteLine
                (
                  " ______________\n" +
                  "|             || '''|'']__,_\n" +
                  "| ____________ || __ | __ | __ |)\n" +
                  "| (@) | (@)'''**|(@)(@)****|(@)\n"
                );
            Console.WriteLine(Name);
        }
    }

    public class Конвертер : IChangable, IConvert, IDrawable
    {
        public Конвертер(string pVolume, double pQuantity)
        {
            Volume = pVolume;
            Quantity = pQuantity;
            Capacity = " oz.";
            CapacityID = 0;
        }

        public Конвертер(string pVolume, double pQuantity, int pCapacityID)
        {
            Volume = pVolume;
            Quantity = pQuantity;

            switch (pCapacityID)
            {
                case 0: Capacity = " oz."; CapacityID = 0; break;
                case 1: Capacity = " litre"; CapacityID = 1; break;
                case 2: Capacity = " gal"; CapacityID = 2; break;
                default: Capacity = " oz."; CapacityID = 0; break;
            }
        }
        private string Volume;
        private double Quantity;
        private string Capacity;
        private int CapacityID;

        public void Growth(double pValue)
        {
            Quantity *= 1.5 * pValue;
        }

        public void Fall(double pValue)
        {
            Quantity *= 0.5 * pValue;
        }

        public string Name
        {
            get
            {
                return $"Мера объема. {Volume}. Значение: {Quantity}{Capacity}";
            }
            set
            {
                Volume = value;
            }
        }

        public void DrawObject()
        {
            Console.WriteLine
                (
                "   V                 \n" +
                "     O               \n" +
                "       L             \n" +
                "         U           \n" +
                "           E         \n" +
                "             M       \n" +
                "               E     \n"

                );
            Console.WriteLine(Name);
        }

        public void ConvertToGallon()
        {
            if (CapacityID == 0)
            {
                Quantity *= 128;
            }
            else if (CapacityID == 1)
            {
                Quantity *= 3.79;
            }
            Capacity = " gal";
            CapacityID = 2;
        }
        public void ConvertToLitre()
        {
            if (CapacityID == 0)
            {
                Quantity *= 33.8;
            }
            else if (CapacityID == 2)
            {
                Quantity *= 0.26;
            }
            Capacity = " litre";
            CapacityID = 1;
        }
        public void ConvertToOunce()
        {
            if (CapacityID == 1)
            {
                Quantity *= 0.029;
            }
            else if (CapacityID == 2)
            {
                Quantity *= 0.0078;
            }
            Capacity = " oz.";
            CapacityID = 0;
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Автомобиль a = new Автомобиль("Mercedes, ", 4);
            a.Growth(3);
            a.Fall(2);
            a.DrawObject();


            Console.WriteLine("\n");
         

            Грузовик g = new Грузовик("MAN", 5);
            g.Growth(3.5);
            g.Fall(2);
            g.DrawObject();

            Console.WriteLine("\n");

            Конвертер c = new Конвертер("Объем двигателя", 5);
            c.Growth(4);
            c.Fall(2);
            c.DrawObject();

            c.ConvertToGallon();
            c.DrawObject();

            Console.ReadKey();
        }
    }
}
