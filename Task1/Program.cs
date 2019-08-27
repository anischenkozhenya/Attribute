using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//Создайте пользовательский атрибут AccessLevelAttribute,
//позволяющий определить уровень доступа пользователя к системе.
//Сформируйте состав сотрудников некоторой фирмы в виде набора
//классов, например, Manager, Programmer, Director
//При помощи атрибута AccessLevelAttribute распределите.
//уровни доступа персонала и отобразите на экране реакцию
//системы на попытку каждого сотрудника получить доступ в защищенную секцию.

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] type = assembly.GetTypes();            
            string KnockOnDoor(Type t)
            {
                AccessLevelAttribute a = null;
                string str = null;
                if (t.BaseType == typeof(Proffession))
                {
                    object[] attr = (object[])t.GetCustomAttributes(typeof(AccessLevelAttribute), false);
                    foreach (object item in attr)
                    {
                        a = item as AccessLevelAttribute;
                        switch (a.Level)
                        {
                            case AccessLevel.Lowlevel:
                                return str = String.Format("{0} Ваш доступ минимален", t.Name);
                            case AccessLevel.MidleLevel:
                                return str = String.Format("{0} Ваш доступ не полный", t.Name);
                            case AccessLevel.HighLevel:
                                return str = String.Format("{0} Ваш доступ не ограничен", t.Name);
                        }
                    }
                }
                return "";
            }
            Director director = new Director("Bob");            
            Programmer programmer = new Programmer("Dima");
            programmer.Name = "Evgeny";        
            Manager manager = new Manager("Yana");


            Console.WriteLine(director.Name + " " + KnockOnDoor(director.GetType()));
            Console.WriteLine(programmer.Name + " " + KnockOnDoor(programmer.GetType()));
            Console.WriteLine(manager.Name + " " + KnockOnDoor(manager.GetType()));


            Console.ReadKey();
        }
    }
}
