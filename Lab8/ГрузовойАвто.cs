using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class ГрузовойАвто : Автомобиль
    {
    public ГрузовойАвто(string СП, string П, string М, КоробкиПередач КП, ТипыДвигателя ТП, Грузоподъемность Г)
            : base(СП, П, М, КП, ТП)
        {
            Груз = Г;
        }
        public Грузоподъемность Груз;

        public override string ХарактеристикаТехСредства
        {
            get
            {
                return base.ХарактеристикаТехСредства + ", " + Груз.ToString();
            }
        }
    }
}
