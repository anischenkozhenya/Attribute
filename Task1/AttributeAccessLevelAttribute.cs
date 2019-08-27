using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class AccessLevelAttribute:Attribute
    {
        private AccessLevel level = AccessLevel.Lowlevel;
        public AccessLevel Level { get { return level; } set { level = value; } }
        public AccessLevelAttribute()
        {
            this.level = AccessLevel.Lowlevel;
        }
        public AccessLevelAttribute(AccessLevel accessLevel)
        {
            this.level = accessLevel;
        }
        public string Date { get; set; }
    }
}
