namespace WebDemo.Models
{
    public class Employee
    {
        //public Employee(int id, string firstName, string lastName, string email, string gender, string avatar, string streetName, int streetNumber, string zipCode, string city, string country)
        //{
        //    Id = id;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Email = email;
        //    Gender = gender;
        //    Avatar = avatar;
        //    StreetName = streetName;
        //    StreetNumber = streetNumber;
        //    ZipCode = zipCode;
        //    City = city;
        //    Country = country;
        //}

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string? Avatar { get; set; }
        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
