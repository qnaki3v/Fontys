using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem.Classes
{
    public class Developer : Employee
    {
        public Developer(string name, int age, decimal monthlySalary) : base(name, age, monthlySalary) { }

        public override string Work()
        {
            return "*Pretends to code all day but just reads on StackOverflow*";
        }
    }
}
