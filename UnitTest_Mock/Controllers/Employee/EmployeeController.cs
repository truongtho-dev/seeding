using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Controllers.Employee.QueryServices;
using UnitTest_Mock.Controllers.Employee.View;

namespace UnitTest_Mock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
		[HttpGet(nameof(GetEmployees))]
		public async Task<IEnumerable<EmployeeView>> GetEmployees(
            [FromServices] IEmployeeService employeeService
            )
		{
            var empList = await employeeService.GetEmployees();
            return empList;
		}

		[HttpGet(nameof(GetEmployeeById))]
        public async Task<string> GetEmployeeById(
            [FromServices] IEmployeeService employeeService,
            int EmpId)
        {
            var result = await employeeService.GetEmployeebyId(EmpId);
            return result;
        }

        [HttpGet(nameof(GetEmployeeDetails))]
        public async Task<EmployeeView> GetEmployeeDetails(
            [FromServices] IEmployeeService employeeService,
            int EmpId)
        {
            var result = await employeeService.GetEmployeeDetails(EmpId);
            return result;
        }

    }
}
