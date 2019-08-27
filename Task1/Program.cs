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
            Director director = new Director("Bob");            
            Programmer programmer = new Programmer("Dima");
            programmer.Name = "Evgeny";        
            Manager manager = new Manager("Yana");  
            Console.WriteLine(director.Name + " " + director.KnockOnDoor());
            Console.WriteLine(programmer.Name + " " + programmer.KnockOnDoor());
            Console.WriteLine(manager.Name + " " + manager.KnockOnDoor());
            Console.WriteLine("Для выхода нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
