using Entities;
using Moq;
using System.Collections.Generic;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Services;
using Xunit;

namespace UnitTesting
{
	public class EmployeeTest
	{
		public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();

		[Fact]
		public async void GetEmployeebId()
		{
			mock.Setup(e => e.GetEmployeebyId(11)).ReturnsAsync("Teo");

			EmployeeController emp = new EmployeeController(mock.Object);

			var result = await emp.GetEmployeeById(11);
			Assert.Equal("Teo", result);
		}

		[Fact]
		public async void GetEmployeeDetail()
		{
			var empDTO = new Employee()
			{
				Name = "Teo",
				Desgination = "Fhghg",
				Id = 10
			};

			mock.Setup(e => e.GetEmployeeDetails(10)).ReturnsAsync(empDTO);
			EmployeeController emp = new EmployeeController(mock.Object);

			var result = await emp.GetEmployeeDetails(10);

			Assert.True(empDTO.Equals(result));
		}

		[Fact]
		public async void GetEmployees()
		{
			var empList = new List<Employee>()
			{
				new Employee
				{
					Name = "Teo",
					Desgination = "Fhghg",
					Id = 10
				},
				new Employee
				{
					 Name = "Ty",
					Desgination = "Fhghgasfas",
					Id = 11
				},
			};

			mock.Setup(e => e.GetEmployees()).ReturnsAsync(empList);
			EmployeeController emp = new EmployeeController(mock.Object);

			var result = await emp.GetEmployees();

			Assert.True(empList.Equals(result));

		}
	}
}
