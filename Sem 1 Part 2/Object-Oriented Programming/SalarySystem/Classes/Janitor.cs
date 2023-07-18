using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem.Classes
{
    public class Janitor : Employee
    {
        public Janitor(string name, int age, decimal monthlySalary) : base(name, age, monthlySalary) { }

        public override string Work()
        {
            return "*Cleans after developers mess*";
        }
    }
}
