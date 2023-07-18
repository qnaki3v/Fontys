using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalarySystem.Classes;
using SalarySystem.Collections;

namespace SalarySystem
{
    public partial class EditEmployee : Form
    {
        public Employee CurrEmployee { get; set; }
        public Employees EmployeesList { get; set; }
        private string type;
        public EditEmployee(Employee employee, Employees employees)
        {
            CurrEmployee = employee;
            EmployeesList = employees;
            InitializeComponent();
            tbName.Text = employee.Name;
            tbAge.Text = employee.Age.ToString();
            tbMonthlySalary.Text = employee.MonthlySalary.ToString();
            type = employee.GetType().ToString().Split('.')[^1];
            cbType.Text = type;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Employee emp = EmployeesList.EmployeesList.First(x => x.Name == CurrEmployee.Name &&
                                                            x.Age == CurrEmployee.Age && 
                                                            x.MonthlySalary == CurrEmployee.MonthlySalary);
            EmployeesList.RemoveEmployee(emp);
            Employee curr;
            switch (type)
            {
                case "Developer":
                    curr = new Developer(tbName.Text, int.Parse(tbAge.Text), decimal.Parse(tbMonthlySalary.Text));
                    break;
                case "Janitor":
                    curr = new Janitor(tbName.Text, int.Parse(tbAge.Text), decimal.Parse(tbMonthlySalary.Text));
                    break;
                case "Boss":
                    curr = new Boss(tbName.Text, int.Parse(tbAge.Text), decimal.Parse(tbMonthlySalary.Text));
                    break;
                default:
                    throw new ArgumentException();
            }
            EmployeesList.AddEmployee(curr);
            // add save to .csv
            Close();
        }
    }
}
