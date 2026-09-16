using Companies.Application.DTOs;
using QuadFlow.SharedKernel.Abstractions;

namespace Companies.Application.Interfaces
{
	public interface IRegisterCompanyUseCase
	{
		Task<Result> Execute(RegisterCompanyRequestDto registerCompanyRequestDto);
	}
}
