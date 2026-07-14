using QuadFlow.Api.Services;
using QuadFlow.SharedKernel.Interfaces;
using System.Globalization;

namespace QuadFlow.Api.Injection
{
	internal static class InfrastructureApi
	{
		public static IServiceCollection AddInfrastructureWeb(this IServiceCollection services)
		{
			services.AddHttpContextAccessor();

			services.AddScoped<ICurrentUser, CurrentUser>();

			return services;
		}
	}
}
