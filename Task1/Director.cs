using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    [AccessLevelAttribute(AccessLevel.HighLevel, Date = "25.6.2000")]
    class Director:Proffession
    {
        public Director(string name) : base(name)
        {

        }
    }
}
