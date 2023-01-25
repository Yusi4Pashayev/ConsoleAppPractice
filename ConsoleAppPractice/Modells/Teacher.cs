using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppPractice.Modells
{
    internal class Teacher : Person
    {
        internal string Subject { get; set; }
        internal Group Group { get; set; }
        internal Department Department { get; set; }

        public override string ToString()
        {
            return $"{Id}\n {FirstName}\n {LastName}\n {FatherName}\n {Age}\n  Subject: {Subject}\n Group: {Group}\n Department:{Department}\n ";
        }
    }    
}
