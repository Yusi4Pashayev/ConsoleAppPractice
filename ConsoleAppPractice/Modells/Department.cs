using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice.Modells
{
    internal class Department : Entity
    {
        internal string Name { get; set; }
        internal Teacher Leader { get; set; }
        internal Teacher[] Teaher { get; set; } = new Teacher[0];

        public override string ToString()
        {
            return $"{Id} {Name} ";
        }

    }
}
