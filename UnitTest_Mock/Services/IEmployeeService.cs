using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTest_Mock.Services
{
   public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<string> GetEmployeebyId(int EmpID);
        Task<Employee> GetEmployeeDetails(int EmpID);
    }
}
