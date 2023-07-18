using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalarySystem.Classes;

namespace SalarySystem.Collections
{
    public class Employees
    {
        public List<Employee> EmployeesList { get; set; }
        public Employees()
        {
            EmployeesList = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            EmployeesList.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            EmployeesList.Remove(employee);
        }
        public int Count()
        {
            return EmployeesList.Count;
        }
    }
}
