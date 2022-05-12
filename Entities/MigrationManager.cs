using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public static class MigrationManager
	{
		public static IHost MigrateDatabase(this IHost host)
		{
			using (var scope = host.Services.CreateScope())
			{
				using (var appContext = scope.ServiceProvider.GetRequiredService<AppDbContext>())
				{
					try
					{
						appContext.Database.Migrate();
					}
					catch (Exception ex)
					{
						throw new Exception($"Cannot seed: {ex.Message}");
					}
				}
			}

			return host;
		}
	}
}
