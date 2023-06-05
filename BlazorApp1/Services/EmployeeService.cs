using DemoModels.Models;
using Microsoft.AspNetCore.DataProtection;

namespace BlazorApp1.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;
        public EmployeeService(HttpClient _httpClient) 
        
        {
            this.httpClient = _httpClient;
        }


        public async Task<List<Employee>> GetEmployees()
        {
            return await httpClient.GetFromJsonAsync<List<Employee>>("api/Employee/GetEmployees");
        }
    }
}
