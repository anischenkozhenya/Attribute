using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Proffession
    {
        public Proffession(string name)
        {
            this.name = name;
        }
        protected string name;
        public string Name { get { return name; } set { name = value; } }
    }
}
