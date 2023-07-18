using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace WriteReadForm
{
    public partial class Form1 : Form
    {
        string filePath = "D:\\Fontys\\Sem 1 Part 2\\Object-Oriented Programming\\WriteReadForm\\employees.json";
        List<Employee> employees;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee person = new Employee(tbFirstName.Text,tbLastName.Text,int.Parse(cbAge.Text));
            
            tbFirstName.Text = "";
            tbLastName.Text = "";
            cbAge.Text = "";

            string employeeJsonData = File.ReadAllText(filePath);
            employees = JsonSerializer.Deserialize<List<Employee>>(employeeJsonData);
            if (employees != null)
                employees.Add(person);

            File.Delete(filePath);
            var json = JsonSerializer.Serialize(employees);
            File.AppendAllText(filePath, json); //file might be locked (timeing issue)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbEmployees.Items.Clear();

            string employeeJsonData = File.ReadAllText(filePath);
            employees = JsonSerializer.Deserialize<List<Employee>>(employeeJsonData);

            foreach (var emp in employees)
            {
                lbEmployees.Items.Add(emp);
            }       
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee)lbEmployees.SelectedItem;
            employees.Remove(emp);
            lbEmployees.Items.Remove(emp);
            File.Delete(filePath);
            var json = JsonSerializer.Serialize(employees);
            File.AppendAllText(filePath, json);
        }
    }
}