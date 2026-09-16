using Products.Application.DTOs;
using Products.Domain.Entities;
using QuadFlow.SharedKernel.Abstractions;

namespace Products.Application.Interfaces
{
	public interface ICreateProductUseCase
	{
		Task<Result<Product>> Execute(CreateProductDto createProductDto);
	}
}
