using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTasks
{
    public class Company
    {
		private string name;
		private List<CompanyTask> tasks;
		private List<Employee> employees;

		public Company(string name)
		{
			this.name = name;
			tasks= new List<CompanyTask>();
			employees= new List<Employee>();
		}

		public string Name
		{
			get { return name; }
		}
		public List<CompanyTask> Tasks
		{
			get { return tasks; }
		}
		public List<Employee> Employees
		{
			get { return employees; }
			set { employees = value; }
		}
	}
}
