using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System
{
    public class Person
    {
        private int age;
        private string name;
        private int pcn;
        protected int yearsAtSchool;

        public Person(int age, string name, int pcn)
        {
            this.age = age;
            this.name = name;
            this.pcn = pcn;
            this.yearsAtSchool = 0;
        }

        public override string ToString()
        {
            return $"PCN: {pcn}, Name: {name}, Age: {age}, Years at School: {yearsAtSchool}";
        }

        public void CelebrateBirthday()
        {
            age++;
        }
        public virtual void StartAnotherSchoolyear()
        {
            yearsAtSchool++;
        }
    }
}
