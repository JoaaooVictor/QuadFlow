using Auth.Application.DTOs;
using QuadFlow.SharedKernel.Abstractions;

namespace Auth.Application.Interfaces
{
	public interface IAuthUserUseCase
	{
		Task<Result<LoginResponseDto>> LoginUser(LoginRequestDto loginRequest);
	}
}
