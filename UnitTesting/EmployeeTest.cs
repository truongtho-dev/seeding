using Entities;
using Moq;
using System.Collections.Generic;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Controllers.Employee.QueryServices;
using Xunit;
using Entities.Model;
using UnitTest_Mock.Controllers.Employee.View;

namespace UnitTesting
{
	public class EmployeeTest
	{
		public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();

		[Fact]
		public async void GetEmployeebyId()
		{
			mock.Setup(e => e.GetEmployeebyId(11)).ReturnsAsync("Teo");

			EmployeeController ec = new EmployeeController(mock.Object);

			var result = await ec.GetEmployeeById(11);
			Assert.Equal("Teo", result);
		}

		[Fact]
		public async void GetEmployeeDetail()
		{
			var empView = new EmployeeView()
			{
				Id = 10,
				Name = "Vu",
			};

			mock.Setup(e => e.GetEmployeeDetails(10)).ReturnsAsync(empView);
			EmployeeController ec = new EmployeeController(mock.Object);

			var result = await ec.GetEmployeeDetails(10);

			Assert.True(empView.Equals(result));
		}

		[Fact]
		public async void GetEmployees()
		{
			var empViewList = new List<EmployeeView>()
			{
				new EmployeeView
				{
					Name = "Teo",
					Id = 10
				},
				new EmployeeView
				{
					Name = "Ty",
					Id = 11
				},
			};

			mock.Setup(e => e.GetEmployees()).ReturnsAsync(empViewList);
			EmployeeController emp = new EmployeeController(mock.Object);

			var result = await emp.GetEmployees();

			Assert.True(empViewList.Equals(result));

		}
	}
}
