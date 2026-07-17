using Companies.Application.Interfaces;
using Companies.Application.UseCases;
using Companies.Domain.Interfaces;
using Companies.Infrastructure.Persistence;
using Companies.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuadFlow.SharedKernel.Interfaces;

namespace Companies.Infrastructure.Injection
{
	public static class InfrastructureCompany
	{
		public static IServiceCollection AddInfrastructureCompany(this IServiceCollection services, string connectionString)
		{
			services.AddDbContext<CompanyDbContext>(options => options.UseSqlServer(connectionString));

			// Registro Repositórios
			services.AddScoped<ICompanyRepository, CompanyRepository>();

			// Registro Use Cases
			services.AddScoped<IRegisterCompanyUseCase, RegisterCompanyUseCase>();
			services.AddScoped<IGetCompanyByUserUseCase, GetCompanyByUserUseCase>();
			services.AddScoped<IUpdateCompanyUseCase, UpdateCompanyUseCase>();

			// Registro UnitOfWork
			services.AddScoped<IUnitOfWork, CompanyUnitOfWork>();
			services.AddScoped<CompanyUnitOfWork>();

			return services;
		}
	}
}
