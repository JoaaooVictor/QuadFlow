using Application.DTOs;

namespace Application.Interfaces
{
	public interface IUserUseCases
	{
		Task<RegisterUserResponseDto> Register(RegisterUserRequestDto request);
	}
}
