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
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
		}
    }
}
