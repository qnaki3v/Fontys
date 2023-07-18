using SalarySystem.Classes;
using SalarySystem.Collections;

namespace SalarySystem
{
    public partial class MainForm : Form
    {
        Employees employees = new Employees();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Employee employee;
            switch (cbType.Text)
            {
                case "Developer":
                    employee = new Developer(tbName.Text, int.Parse(tbAge.Text), decimal.Parse(tbMonthlySalary.Text));
                    break;
                case "Janitor":
                    employee = new Janitor(tbName.Text, int.Parse(tbAge.Text), decimal.Parse(tbMonthlySalary.Text));
                    break;
                case "Boss":
                    employee = new Boss(tbName.Text, int.Parse(tbAge.Text), decimal.Parse(tbMonthlySalary.Text));
                    break;
                default:
                    throw new ArgumentException();
            }
            employees.AddEmployee(employee);
        }

        private void BtnShowHideEmployees_Click(object sender, EventArgs e)
        {
            if (btnShowEmployees.Text == "Show Employees")
            {
                btnShowEmployees.Text = "Hide Employees";
                lbEmployees.Items.Clear();
                foreach (Employee emp in employees.EmployeesList)
                {
                    lbEmployees.Items.Add(emp);
                }
            }
            else
            {
                btnShowEmployees.Text = "Show Employees";
                lbEmployees.Items.Clear();
            }
        }

        private void BtnShowInfo_Click(object sender, EventArgs e)
        {
            Employee curr = (Employee)lbEmployees.SelectedItem;
            MessageBox.Show(curr.ToString(), "Employee Information");
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            Employee curr = (Employee)lbEmployees.SelectedItem;
            MessageBox.Show(curr.Work(), "Working");
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Employee curr = (Employee)lbEmployees.SelectedItem;
            employees.RemoveEmployee(curr);
            lbEmployees.Items.Remove(curr);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Employee curr = (Employee)lbEmployees.SelectedItem;
            EditEmployee editEmployee = new(curr, employees);
            editEmployee.Show();
        }
    }
}