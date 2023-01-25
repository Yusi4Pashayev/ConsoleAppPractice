using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice.Modells
{
    internal class Group : Entity
    {
        internal string Name { get; set; }
        internal Teacher[] Teachers { get; set; } = new Teacher[0];
        internal Student[] Students { get; set; } = new Student[0];

        public override string ToString()
        {
            return $"{Id} {Name} ";
        }
    }
}
