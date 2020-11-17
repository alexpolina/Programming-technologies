using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class ТехСредство
    {

        public ТехСредство(string СП, string П, string М)
        {
            СтранаПроизводства = СП; Производитель = П; Модель = М; 
        }

        public ТехСредство()
        {
            СтранаПроизводства = " "; Производитель = " "; Модель = " ";
          
        }

        public string СтранаПроизводства, Производитель, Модель;

        public virtual string ХарактеристикаТехСредства
        {
            get { return СтранаПроизводства + ", " + Производитель + ", " + Модель; }

        }
       
    }
}