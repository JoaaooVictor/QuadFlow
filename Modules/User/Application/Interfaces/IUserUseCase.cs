using Users.Application.DTOs.UserDtos;
using Users.Domain.Entities;
using QuadFlow.SharedKernel.Abstractions;

namespace Users.Application.Interfaces
{
	public interface IUserUseCases
	{
		Task<Result> Register(RegisterUserRequestDto request);
		Task<Result<GetUserByIdResponse>> GetUserById(int id);
 	}
}
