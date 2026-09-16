using Users.Application.Interfaces;
using Users.Application.UseCases;
using Users.Application.Services;
using Users.Contracts.Interfaces;
using Users.Domain.Interfaces;
using Users.Infrastructure.Persistence;
using Users.Infrastructure.Repositories;
using Users.Infrastructure.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuadFlow.SharedKernel.Interfaces;

namespace Users.Infrastructure.Injection
{
	public static class InfrastructureUser
	{
		public static IServiceCollection AddInfrastructureUser(this IServiceCollection services, string connectionString)
		{
			services.AddDbContext<UserDbContext>(options => options.UseSqlServer(connectionString));

			// Registro Repositórios
			services.AddScoped<IUserRepository, UserRepository>();

			// Registro Serviços
			services.AddScoped<IPasswordHash, BcryptPasswordHasher>();
			services.AddScoped<IUserAuthenticationService, UserAuthenticationService>();

			// Registro Use Cases
			services.AddScoped<IGetUserByIdUseCase, GetUserByIdUseCase>(); 
			services.AddScoped<IRegisterUserUseCase, RegisterUserUseCase>();

			// Registro UnitOfWork
			services.AddScoped<UserUnitOfWork>();

			return services;
		}
	}
}
