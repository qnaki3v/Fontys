using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem.Classes
{
    public class Boss : Employee
    {
        public Boss(string name, int age, decimal monthlySalary) : base(name, age, monthlySalary) { }

        public override string Work()
        {
            return "*Sits with his legs crossed and doesn't do anything because he is boss*";
        }
    }
}
