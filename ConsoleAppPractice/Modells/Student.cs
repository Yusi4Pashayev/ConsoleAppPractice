using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice.Modells
{
    internal class Student : Person
    {
        internal string Course { get; set; }
        internal DateTime EntryDate { get; set; }
        internal string Group { get; set; }
        internal Subject[] Subjects { get; set; }

        public override string ToString()
        {
            return $"{Id}\n {FirstName}\n {LastName}\n {FatherName}\n {Age}\n Course: {Course}\n EntryDate: {EntryDate}\n Group:{Group}\n ";
        }



    }
}
