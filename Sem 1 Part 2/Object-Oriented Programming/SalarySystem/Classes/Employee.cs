using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem.Classes
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal MonthlySalary { get; set; }

        public Employee(string name, int age, decimal monthlySalary)
        {
            Name = name;
            Age = age;
            MonthlySalary = monthlySalary;
        }
        public abstract string Work();
        public override string ToString()
        {
            string[] type = GetType().ToString().Split('.');
            return $"{Name} is {Age} year(s) old {type[^1].ToLower()} recieving {MonthlySalary} euro monthly.";
        }
    }
}
