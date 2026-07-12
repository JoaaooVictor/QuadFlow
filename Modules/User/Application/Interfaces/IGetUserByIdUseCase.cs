using QuadFlow.SharedKernel.Abstractions;
using Users.Application.DTOs.UserDtos;

namespace Users.Application.Interfaces
{
	public interface IGetUserByIdUseCase
	{
		Task<Result<GetUserByIdResponse>> Execute(int id);
	}
}
