using QuadFlow.SharedKernel.Interfaces;
using SharedKernel.ValueObjects;
using System.Security.Claims;

namespace QuadFlow.Api.Services
{
	public sealed class CurrentUser : ICurrentUser
	{
		private readonly IHttpContextAccessor _contextAccessor;

		public CurrentUser(IHttpContextAccessor contextAccessor)
		{
			_contextAccessor = contextAccessor;
		}
			
		public int UserId => int.Parse(_contextAccessor.HttpContext!.User.FindFirst("UserId")!.Value);

		public Email email => new Email(_contextAccessor.HttpContext!.User.FindFirst(ClaimTypes.Email)!.Value);
	}
}
