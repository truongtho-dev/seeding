using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeModel = Entities.Model.Employee;

namespace UnitTest_Mock.Controllers.Employee.View
{
	public class EmployeeViewMapperProfile: Profile
	{
		public EmployeeViewMapperProfile()
		{
			CreateMap<EmployeeModel, EmployeeView>();
		}
	}
}
