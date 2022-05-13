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

			var empController = new EmployeeController();

			var result = await empController.GetEmployeeById(mock.Object, 11);
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
			var empController = new EmployeeController();

			var result = await empController.GetEmployeeDetails(mock.Object, 10);

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
			var empController = new EmployeeController();

			var result = await empController.GetEmployees(mock.Object);

			Assert.True(empViewList.Equals(result));

		}
	}
}
