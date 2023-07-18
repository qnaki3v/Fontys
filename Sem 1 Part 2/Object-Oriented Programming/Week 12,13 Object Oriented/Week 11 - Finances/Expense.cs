using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11___Finances
{
    public class Expense
    {
        public Expense(string name, double amount)
        {
            Name = name;
            Amount = amount;
        }
        public string Name { get; set; }
        public double Amount { get; set; }

        public string GetInfo()
        {
            return $"{Name} - {Amount}";
        }
    }
}
