using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class Автомобиль : ТехСредство
    {
        public Автомобиль(string СП, string П, string М, КоробкиПередач КП, ТипыДвигателя ТП)
            :base(СП, П, М)
        {
            КоробкаПередач = КП;
            ТипДвигателя = ТП;
        }
        public КоробкиПередач КоробкаПередач;
        public ТипыДвигателя ТипДвигателя;

        public override string ХарактеристикаТехСредства
        {
            get
            {
                return base.ХарактеристикаТехСредства + ", " + КоробкаПередач.ToString() + ", " + ТипДвигателя.ToString();
            }
        }
    }
}
