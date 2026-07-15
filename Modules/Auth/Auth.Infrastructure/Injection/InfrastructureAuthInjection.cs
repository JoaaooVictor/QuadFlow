using Auth.Application.Interfaces;
using Auth.Application.UseCases;
using Auth.Infrastructure.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Auth.Infrastructure.Injection;

public static class InfrastructureAuthInjection
{
	public static IServiceCollection AddAuthConfiguration(this IServiceCollection services, IConfiguration configuration)
	{
		var key = configuration["Jwt:Key"];
		var issuer = configuration["Jwt:Issuer"];
		var audience = configuration["Jwt:Audience"];

		services.AddScoped<IAuthUserUseCase, AuthUserUseCase>();
		services.AddScoped<IJwtProvider, JwtProvider>();

		services.AddAuthentication(options =>
		{
			options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
			options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
		})
		.AddJwtBearer(options =>
		{
			options.TokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuer = true,
				ValidateAudience = true,
				ValidateLifetime = true,
				ValidateIssuerSigningKey = true,
				ValidIssuer = issuer,
				ValidAudience = audience,
				IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key!))
			};
		});

		return services;
	}
}
