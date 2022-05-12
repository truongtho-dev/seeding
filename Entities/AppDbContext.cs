using Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            //       modelBuilder.Entity<Employee>()
            //           .HasData(
            //               new Employee
            //{
            //                   Id = 1,
            //                   Name = "Teo",
            //                   Desgination = "Fresher"
            //},
            //               new Employee
            //               {
            //                   Id = 2,
            //                   Name = "Ty",
            //                   Desgination = "Junior"
            //               },
            //               new Employee
            //               {
            //                   Id = 3,
            //                   Name = "Tun",
            //                   Desgination = "Senior"
            //               }
            //           );

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
		}
    }
}
