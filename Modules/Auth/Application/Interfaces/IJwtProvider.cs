
using Contracts.DTOs;

namespace Auth.Application.Interfaces
{
	public interface IJwtProvider
	{
		Task<string> GenerateToken(UserAuthenticationDto userAuthenticationDto);
	}
}
