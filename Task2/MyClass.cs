using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    [Obsolete("Не стоит исспользовать этот класс, возможно он устарел", false)]
    class MyClass
    {        
        [Obsolete("Метод помечен предупреждением", false)]
        public void MethodWarning()
        {
            Console.WriteLine("Любой текст");
        }
        [Obsolete("Все правильно,но благодаря атрибуту выдается ошибка", true)]
        public string Name { get; set; }
        [Obsolete("Все правильно,но благодаря атрибуту выдается ошибка", true)]
        public void MethodError()
        {
            Console.WriteLine("Какой-то текст");
        }
    }
}
