using Application.Interfaces;
using Application.UseCases;
using Domain.Interfaces;
using Infrastructure.Authentication;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuadFlow.SharedKernel.Interfaces;

namespace Infrastructure.Injection
{
	public static class InfrastructureUserInjection
	{
		public static IServiceCollection AddInfrastructureUser(this IServiceCollection services, string connectionString)
		{
			services.AddDbContext<UserDbContext>(options => options.UseSqlServer(connectionString));

			// Registro Repositórios
			services.AddScoped<IUserRepository, UserRepository>();

			// Registro Serviços
			services.AddScoped<IJwtProvider, JwtProvider>();
			services.AddScoped<IUserUseCases, UserUseCases>();
			services.AddScoped<IUnitOfWork, UserUnitOfWork>();

			return services;
		}
	}
}
