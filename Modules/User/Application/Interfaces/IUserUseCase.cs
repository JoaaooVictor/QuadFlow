using Application.DTOs.UserDtos;
using Domain.Entities;
using QuadFlow.SharedKernel.Abstractions;

namespace Application.Interfaces
{
	public interface IUserUseCases
	{
		Task<Result> Register(RegisterUserRequestDto request);
		Task<Result<GetUserByIdResponse>> GetUserById(int id);
 	}
}
