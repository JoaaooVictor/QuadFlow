using Companies.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Companies.Infrastructure.Injection
{
	public static class InfrastructureCompany
	{
		public static IServiceCollection AddInfrastructureCompany(this IServiceCollection services, string connectionString)
		{
			services.AddDbContext<CompanyDbContext>(options => options.UseSqlServer(connectionString));

			// Registro Repositórios

			// Registro Serviços

			// Registro Use Cases

			return services;
		}
	}
}
