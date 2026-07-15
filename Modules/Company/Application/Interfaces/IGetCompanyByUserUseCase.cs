using Companies.Application.DTOs;
using QuadFlow.SharedKernel.Abstractions;

namespace Companies.Application.Interfaces
{
	public interface IGetCompanyByUserUseCase
	{
		Task<Result<ResponseGetCompanyByUserDto>> Execute();
	}
}
