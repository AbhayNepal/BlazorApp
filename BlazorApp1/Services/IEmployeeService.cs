using DemoModels.Models;

namespace BlazorApp1.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
    }
}
