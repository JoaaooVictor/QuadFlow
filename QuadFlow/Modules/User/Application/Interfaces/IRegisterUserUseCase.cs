using Users.Application.DTOs.UserDtos;
using QuadFlow.SharedKernel.Abstractions;

namespace Users.Application.Interfaces
{
	public interface IRegisterUserUseCase
	{
		Task<Result> Execute(RegisterUserRequestDto request);
 	}
}
