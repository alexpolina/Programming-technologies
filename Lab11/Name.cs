using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab11
{
    enum Category
    {
        бухгалтеры,
        инженеры,
        программисты,

    }

    class Name
    {
        String ID { get; set; }
        String Fname { get; set; }
        String Lname { get; set; }
        public Category CategoryName { get; set; }
        public float Money { get; set; }
        public Boolean HasDiploma { get; set; }

        public static Name Create(String str)
        {
            Name p = new Name();
            //string[] e = str.Split(',');
            string[] e = Regex.Split(str, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            p.ID = e[0].Trim();
            p.Fname = e[1].Trim();
            p.Lname = e[2].Trim();
            String tmp = e[3].Trim();
            if (tmp == "бухгалтеры")
                p.CategoryName = Category.бухгалтеры;
            else if (tmp == "инженеры")
                p.CategoryName = Category.инженеры;
            else 
                p.CategoryName = Category.программисты;

            p.Money = Convert.ToSingle(e[4].TrimStart('$').Replace('.', ','));
            p.HasDiploma = Convert.ToBoolean(e[5].Trim());

            return p;
        }

        public static String CompanyToStr(Category c)
        {
            if (c == Category.бухгалтеры) return "бухгалтеры";
            else if (c == Category.инженеры) return "инженеры";
            else return "программисты";
        }

        public static String HasDiplomaSt(Boolean d)
        {
            if (d == true) return "Есть диплом";
            else return "Нет диплома";
        }

        public override string ToString()
        {
            String s = string.Format(
                "/////////////////////////////////////////////////////////\n" +
                "ID: {0} \n"+
                "Имя: {1}\n" +
                "Фамилия: {2}\n" +
                "Категория: {3}\n" +
                "Зарплата: {4} $\n" +
                "Наличие диплома: {5}\n" +
                "/////////////////////////////////////////////////////////\n",
                ID, Fname, Lname, CategoryName, Money, HasDiplomaSt(HasDiploma));
            return s;
        }
    }
}
