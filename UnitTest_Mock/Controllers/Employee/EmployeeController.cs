﻿using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
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
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

		[HttpGet(nameof(GetEmployees))]
		public async Task<IEnumerable<EmployeeView>> GetEmployees()
		{
            var empList = await _employeeService.GetEmployees();
            return empList;
		}

		[HttpGet(nameof(GetEmployeeById))]
        public async Task<string> GetEmployeeById(int EmpID)
        {
            var result = await _employeeService.GetEmployeebyId(EmpID);
            return result;
        }

        [HttpGet(nameof(GetEmployeeDetails))]
        public async Task<EmployeeView> GetEmployeeDetails(int EmpId)
        {
            var result = await _employeeService.GetEmployeeDetails(EmpId);
            return result;
        }

    }
}