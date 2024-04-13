using EmployeeMgt.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeMgt.Core.DTOs;

namespace EmployeeMgt.Core.Services
{
    public interface IEmployeeRepository
    {
        Task<string> AddEmployee(AddEmployeeDTO employee);
        Task<List<Employee>> GetAll();
        Task<Employee> GetEmployeeById(int id);
        Task<string> UpdateEmployee(Employee employee);
        Task<string> DeleteEmployeeById(int id);
    }
}
