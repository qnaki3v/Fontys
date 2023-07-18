using System.Data.SqlClient;
using WebDemo.Data;
using WebDemo.Models;

namespace WebDemo.Repositories
{
    public class EmployeeRepository
    {
        SqlConnection connection = Database.GetConnection();
        public List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>();
            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM MOCK_EMPLOYEE_DATA", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee
                    { 
                        Id = (int)reader["id"],
                        FirstName = (string)reader["first_name"],
                        LastName = (string)reader["last_name"],
                        Email = (string)reader["email"],
                        Gender = (string)reader["gender"],
                        Avatar = Convert.IsDBNull(reader["avatar"]) ? null : (string)reader["avatar"],
                        StreetName = Convert.IsDBNull(reader["street_name"]) ? null : (string)reader["street_name"],
                        StreetNumber = Convert.IsDBNull(reader["street_number"]) ? null : (string)reader["street_number"],
                        ZipCode = Convert.IsDBNull(reader["zip_code"]) ? null : (string)reader["zip_code"],
                        City = Convert.IsDBNull(reader["city"]) ? null : (string)reader["city"],
                        Country = Convert.IsDBNull(reader["country"]) ? null : (string)reader["country"]
                    };

                    employees.Add(employee);
                }
                reader.Close();
            }
            return employees;
        }
        public Employee GetById (int id)
        {
            Employee employee = new Employee();
            using (connection)
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM MOCK_EMPLOYEE_DATA WHERE id = {id}", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    employee = new Employee
                    {
                        Id = (int)reader["id"],
                        FirstName = (string)reader["first_name"],
                        LastName = (string)reader["last_name"],
                        Email = (string)reader["email"],
                        Gender = (string)reader["gender"],
                        Avatar = Convert.IsDBNull(reader["avatar"]) ? null : (string)reader["avatar"],
                        StreetName = Convert.IsDBNull(reader["street_name"]) ? null : (string)reader["street_name"],
                        StreetNumber = Convert.IsDBNull(reader["street_number"]) ? null : (string)reader["street_number"],
                        ZipCode = Convert.IsDBNull(reader["zip_code"]) ? null : (string)reader["zip_code"],
                        City = Convert.IsDBNull(reader["city"]) ? null : (string)reader["city"],
                        Country = Convert.IsDBNull(reader["country"]) ? null : (string)reader["country"]
                    };
                }
                reader.Close();
            }
            return employee;
        }
    }
}
