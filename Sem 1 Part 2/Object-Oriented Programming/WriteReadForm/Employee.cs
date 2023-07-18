using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteReadForm
{
    [Serializable]
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Employee(string firstName, string lastName,int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age; 
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age} years old.";
        }
    }
}
