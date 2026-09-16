using Products.Application.Interfaces;
using Products.Domain.Entities;
using Products.Domain.Interfaces;
using QuadFlow.SharedKernel.Abstractions;

namespace Products.Application.UseCases
{
	public class GetAllProductsUseCase : IGetAllProductsUseCase
	{
		private readonly IProductRepository _productRepository;

		public GetAllProductsUseCase(IProductRepository productRepository)
		{
			this._productRepository = productRepository;
		}

		public async Task<Result<List<Product>>?> Execute()
		{
			return Result<List<Product>>.Success("Produtos encontrados", await _productRepository.GetAllProducts());
		}
	}
}
