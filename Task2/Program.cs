using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.MethodWarning();
            //для проверки раскоментировать
            //instance.MethodError();    
            Console.ReadKey();
        }
    }
}
