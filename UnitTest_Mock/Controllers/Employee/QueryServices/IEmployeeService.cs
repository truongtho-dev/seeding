using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Controllers.Employee.View;

namespace UnitTest_Mock.Controllers.Employee.QueryServices
{
   public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeView>> GetEmployees();
        Task<string> GetEmployeebyId(int EmpId);
        Task<EmployeeView> GetEmployeeDetails(int EmpId);
    }
}
