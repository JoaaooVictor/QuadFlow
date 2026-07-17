using Companies.Application.DTOs;
using QuadFlow.SharedKernel.Abstractions;

namespace Companies.Application.Interfaces
{
	public interface IUpdateCompanyUseCase
	{
		Task<Result> Execute(UpdateCompanyDto updateCompanyDto);
	}
}
