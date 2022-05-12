﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Model;
using Microsoft.EntityFrameworkCore;

namespace UnitTest_Mock.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<string> GetEmployeebyId(int EmpID)
        {
            var name = await _appDbContext.Employees.Where(c=>c.Id == EmpID).Select(d=> d.Name).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Employee> GetEmployeeDetails(int EmpID)
        {
            var emp = await _appDbContext.Employees.FirstOrDefaultAsync(c => c.Id == EmpID);
            return emp;
        }

		public async Task<IEnumerable<Employee>> GetEmployees()
		{
            var listEmp = await _appDbContext.Employees.ToListAsync();
            return listEmp;
		}
	}
}
