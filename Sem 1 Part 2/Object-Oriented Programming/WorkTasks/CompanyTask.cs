namespace WorkTasks
{
    public class CompanyTask
    {
		private string title;
		private List<string> departments;
		private List<Employee> employeesAssigned;
		private string status;
		private DateTime deadline;
		private string? author;
		private string description;

		public CompanyTask(string title, string status, DateTime deadline, string? author, string description)
		{
			this.title = title;
			this.departments = new List<string>();
			this.employeesAssigned = new List<Employee>();
			this.status = status;
			this.deadline = deadline;
			this.author = author;
			this.description = description;
		}

		public string Title
		{
			get { return title; }
		}
		public List<string> Departments
		{
			get { return departments; }
		}
		public List<Employee> EmployeesAssigned
		{ 
			get { return employeesAssigned; } 
		}
        public string Status
		{
			get { return status; }
			set { status = value; }
		}
		public DateTime Deadline
		{
			get { return deadline; }
		}
		public string Author
		{
			get { return author; }
		}
		public string Description
		{
			get { return description; }
		}

        public override string ToString()
        {
            return $"{Title} by {Author} DEADLINE: {Deadline}";
        }
    }
}