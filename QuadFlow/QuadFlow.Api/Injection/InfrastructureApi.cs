using Microsoft.OpenApi.Models;
using QuadFlow.Api.Services;
using QuadFlow.SharedKernel.Interfaces;
using System.Reflection;

namespace QuadFlow.Api.Injection
{
	public static class InfrastructureApi
	{
		public static IServiceCollection AddInfrastructureWeb(this IServiceCollection services)
		{
			services.AddHttpContextAccessor();

			services.AddScoped<ICurrentUser, CurrentUser>();

			services.AddEndpointsApiExplorer();

			services.AddSwaggerGen(options =>
			{
				options.SwaggerDoc("v1", new OpenApiInfo
				{
					Title = "QuadFlow API",
					Version = "v1",
					Description = "API do sistema QuadFlow"
				});

				options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				{
					Name = "Authorization",
					Type = SecuritySchemeType.Http,
					Scheme = "bearer",
					BearerFormat = "JWT",
					In = ParameterLocation.Header,
					Description = """
					  Informe apenas o token JWT.

					  Exemplo:
					  eyJhbGciOiJIUzI1NiIs...
					  """
				});

				options.AddSecurityRequirement(new OpenApiSecurityRequirement
				{
					{
						new OpenApiSecurityScheme
						{
							Reference = new OpenApiReference
							{
								Type = ReferenceType.SecurityScheme,
								Id = "Bearer"
							}
						},
						Array.Empty<string>()
					}
				});

				var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
			});

			return services;
		}
	}
}
