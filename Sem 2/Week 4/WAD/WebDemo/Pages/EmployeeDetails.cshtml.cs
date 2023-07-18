using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebDemo.Models;
using WebDemo.Repositories;

namespace WebDemo.Pages.Shared
{
    public class EmployeeDetailsModel : PageModel
    {
		private readonly EmployeeRepository employeeRepository;
        public EmployeeDetailsModel(EmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public Employee Employee { get; set; }
        public void OnGet(int id)
        {
            Employee = employeeRepository.GetById(id);
        }
    }
}
