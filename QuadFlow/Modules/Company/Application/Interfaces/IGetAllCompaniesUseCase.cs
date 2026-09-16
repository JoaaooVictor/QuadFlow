using Companies.Domain.Entities;
using QuadFlow.SharedKernel.Abstractions;

namespace Companies.Application.Interfaces
{
	public interface IGetAllCompaniesUseCase
	{
		Task<Result<List<Company>>> Execute();
	}
}
