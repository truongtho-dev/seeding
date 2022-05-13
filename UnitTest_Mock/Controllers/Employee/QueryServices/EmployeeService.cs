using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entities;
using Microsoft.EntityFrameworkCore;
using UnitTest_Mock.Controllers.Employee.View;
using Microsoft.AspNetCore.Mvc;

namespace UnitTest_Mock.Controllers.Employee.QueryServices
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public EmployeeService(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<string> GetEmployeebyId(int EmpId)
        {
            var name = await _appDbContext.Employees.Where(c=>c.Id == EmpId).Select(d=> d.Name).FirstOrDefaultAsync();
            return name;
        }

        public async Task<EmployeeView> GetEmployeeDetails(int EmpId)
        {
            var emp = await _appDbContext.Employees.FirstOrDefaultAsync(c => c.Id == EmpId);
            var empView = _mapper.Map<EmployeeView>(emp);
            return empView;
        }

		public async Task<IEnumerable<EmployeeView>> GetEmployees()
		{
            var listEmp = await _appDbContext.Employees.ToListAsync();
            var listEmpView = _mapper.Map<List<EmployeeView>>(listEmp);
            return listEmpView;
		}
	}
}
