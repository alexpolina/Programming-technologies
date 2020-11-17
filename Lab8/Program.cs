﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public enum Транспорт
    {
        Наземный,
        Воздушный,
        Водный,
        Подземный
    }

    public enum Виды
    {
        Универсальный,
        Внутренний,
        Внешний,
        Специальный
    }

    public enum Структура
    {
        Магистральный,
        Немагистральный
    }
    public enum КоробкиПередач
    {
        АКПП,
        МКП
    }
    public enum ТипыДвигателя
    {
        Бензин,
        Газ
    }
    public enum Грузоподъемность
    {
        Высокая,
        Средняя,
        Малая
    }
    public enum ВместимостьПассажиров
    {
        _3_человека,
        _4_человека,
        _6_человек

    }

    class Program
    {
        static void Main(string[] args)
        {
            ТехСредство[] mas = new ТехСредство[5];

            mas[0] = new ТехСредство("СССР", "Ленинрадское адмиралтейское объединение", "ледокол Ленин");
            mas[1] = new Вертолет("Россия", "Казанский вертолетный завод", "МИ-8", Транспорт.Воздушный, Виды.Специальный, Структура.Немагистральный);
            mas[2] = new Автомобиль("Россия", "Лада", "Калина", КоробкиПередач.МКП, ТипыДвигателя.Бензин);
            mas[3] = new ЛегковойАвто("Германия", "Mercedes-Benz", "Mercedes GLS X167", КоробкиПередач.АКПП, ТипыДвигателя.Бензин, ВместимостьПассажиров._6_человек);
            mas[4] = new ГрузовойАвто("Германия", "MAN", "MAN TGX 18.680", КоробкиПередач.АКПП, ТипыДвигателя.Бензин, Грузоподъемность.Высокая);

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(">>>>>>>>>>>>>     " + mas[i].GetType().Name);
                Console.WriteLine(mas[i].ХарактеристикаТехСредства);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}