using Products.Domain.Entities;
using QuadFlow.SharedKernel.Abstractions;

namespace Products.Application.Interfaces
{
	public interface IGetAllProductsUseCase
	{
		Task<Result<List<Product>>?> Execute();
	}
}
