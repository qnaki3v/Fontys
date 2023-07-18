using Microsoft.AspNetCore.Mvc.RazorPages;
using WebDemo.Models;
using WebDemo.Repositories;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace WebDemo.Pages
{
    public class EmployeesModel : PageModel
    {
        private readonly EmployeeRepository employeeRepository;

        public EmployeesModel(EmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public IPagedList<Employee> EmployeeList { get; set; }
        public void OnGet()
        {
            int pageSize = 12;
            int pageNumber = Request.Query.ContainsKey("page") && int.TryParse(Request.Query["page"], out int p) ? p : 1;
            EmployeeList = employeeRepository.GetAllEmployees().ToPagedList(pageNumber, pageSize);
        }
    }
}
