using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class MyClass
    {
        /// <summary>
        /// Метод постучать в дверь
        /// </summary>
        /// <param name="proffession">Обьект класса Proffession</param>
        /// <returns></returns>
        public static string KnockOnDoor(this Proffession proffession)
        {
            var t = proffession.GetType();
            AccessLevelAttribute attribute = null;
            string str = null;
            if (t.BaseType == typeof(Proffession))
            {
                object[] arrayattribute = (object[])t.GetCustomAttributes(typeof(AccessLevelAttribute), false);
                foreach (object item in arrayattribute)
                {
                    attribute = item as AccessLevelAttribute;
                    switch (attribute.Level)
                    {
                        case AccessLevel.Lowlevel:
                            return str = String.Format("{0} Ваш доступ минимален c {1}", t.Name, attribute.Date);
                        case AccessLevel.MidleLevel:
                            return str = String.Format("{0} Ваш доступ не полный c {1}", t.Name, attribute.Date);
                        case AccessLevel.HighLevel:
                            return str = String.Format("{0} Ваш доступ не ограничен c {1}", t.Name, attribute.Date);
                    }
                }
            }
            return "Такой профессии нет";
        }
    }
}
