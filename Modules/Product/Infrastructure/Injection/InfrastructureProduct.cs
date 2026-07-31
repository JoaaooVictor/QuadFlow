using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Products.Infrastructure.Persistence;

namespace Products.Infrastructure.Injection
{
	public static class InfrastructureProduct
	{
		public static IServiceCollection AddInfrastructureProduct(this IServiceCollection services, string connectionString)
		{
			services.AddDbContext<ProductDbContext>(options => options.UseSqlServer(connectionString));

			// Registro Repositórios

			// Registro Use Cases

			// Registro Services

			// Registro UnitOfWork

			return services;
		}
	}
}
