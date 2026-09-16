using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Products.Application.Interfaces;
using Products.Application.UseCases;
using Products.Domain.Interfaces;
using Products.Infrastructure.Persistence;
using Products.Infrastructure.Repositories;
using QuadFlow.SharedKernel.Interfaces;

namespace Products.Infrastructure.Injection
{
	public static class InfrastructureProduct
	{
		public static IServiceCollection AddInfrastructureProduct(this IServiceCollection services, string connectionString)
		{
			services.AddDbContext<ProductDbContext>(options => options.UseSqlServer(connectionString));

			// Registro Repositórios
			services.AddScoped<IProductRepository, ProductRepository>();

			// Registro Use Cases
			services.AddScoped<ICreateProductUseCase, CreateProductUseCase>();
			services.AddScoped<IGetAllProductsUseCase, GetAllProductsUseCase>();

			// Registro Services

			// Registro UnitOfWork
			services.AddScoped<IUnitOfWork, ProductUnitOfWork>();
			services.AddScoped<ProductUnitOfWork>();

			return services;
		}
	}
}
