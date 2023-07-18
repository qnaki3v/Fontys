using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System
{
    public class Student : Person
    {
        private int nrOfECs;

        public Student(int age, string name, int pcn) : base(age, name, pcn)
        {
            nrOfECs = 0;
        }

        public void AddECs(int n)
        {
            nrOfECs += n;
        }
    }
}
