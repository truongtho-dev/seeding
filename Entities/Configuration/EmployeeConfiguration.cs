using Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
	public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
            builder.HasData(
                new Employee
                {
                    Id = 1,
                    Name = "David Teo",
                    Desgination = "Fresher"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Ty",
                    Desgination = "Junior"
                },
                new Employee
                {
                    Id = 3,
                    Name = "Tun",
                    Desgination = "Senior"
                }
                );

        }
	}
}
