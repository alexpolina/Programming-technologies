using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class ЛегковойАвто : Автомобиль
    {
        public ЛегковойАвто(string СП, string П, string М, КоробкиПередач КП, ТипыДвигателя ТП, ВместимостьПассажиров ВП)
                : base(СП, П, М, КП, ТП)
        {
            Пассажиры = ВП;
        }
        public ВместимостьПассажиров Пассажиры;

        public override string ХарактеристикаТехСредства
        {
            get
            {
                return base.ХарактеристикаТехСредства + ", " + Пассажиры.ToString();
            }
        }
    }
}