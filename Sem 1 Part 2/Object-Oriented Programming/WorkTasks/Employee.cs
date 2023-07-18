namespace WorkTasks
{
    public class Employee
    {
		private int id;
		private string ssn;
		private string firstName;
		private string lastName;
		private string gender;
		private string streetName;
		private int streetNumber;
		private string zipcode;
		private string city;
		private string email;
		private string department;

		public Employee(int id, string ssn, string firstName, string lastName, string gender, string streetName, int streetNumber, string zipcode, string city, string email, string department)
		{
			this.id = id;
			this.ssn = ssn;
			this.firstName = firstName;
			this.lastName = lastName;
			this.gender = gender;
			this.streetName = streetName;
			this.streetNumber = streetNumber;
			this.zipcode = zipcode;
			this.city = city;
			this.email = email;
			this.department = department;
		}

		public int Id
		{
			get { return id; }
		}
		public string SSN
		{
			get { return ssn; }
		}
		public string FirstName
		{
			get { return firstName; }
		}
		public string LastName
		{
			get { return lastName; }
		}
		public string Gender
		{
			get { return gender; }
		}
		public string StreetName
		{
			get { return streetName; }
		}
		public int StreetNumber
		{
			get { return streetNumber; }
		}
		public string Zipcode
		{
			get { return zipcode; }
		}
		public string City
		{
			get { return city; }
		}
		public string Email
		{
			get { return email; }
		}

		public string Department
		{
			get { return department; }
		}

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Department}";
        }
    }
}