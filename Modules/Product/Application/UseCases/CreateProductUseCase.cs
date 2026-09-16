using Companies.Contracts.Interfaces;
using Companies.Domain.Entities;
using Products.Application.DTOs;
using Products.Application.Interfaces;
using Products.Domain.Entities;
using Products.Domain.Interfaces;
using QuadFlow.SharedKernel.Abstractions;
using QuadFlow.SharedKernel.Interfaces;

namespace Products.Application.UseCases
{
	public class CreateProductUseCase : ICreateProductUseCase
	{
		private readonly IProductRepository _productRepository;
		private readonly IGetCompanyByUserService _getCompanyByUserService;
		private readonly ICurrentUser _currentUser;

		public CreateProductUseCase(IProductRepository productRepository, IGetCompanyByUserService getCompanyByUserService, ICurrentUser currentUser)
		{
			_productRepository = productRepository;
			_getCompanyByUserService = getCompanyByUserService;
			_currentUser = currentUser;
		}

		public async Task<Result<Product>> Execute(CreateProductDto createProductDto)
		{
			int userId = _currentUser.UserId;

			if (userId is 0)
			{
				return Result<Product>.Fail("Nenhum usuário autenticado.");
			}

			var company = await _getCompanyByUserService.GetCompanyByUserId(userId);

			if (company is null)
			{
				return Result<Product>.Fail("Usuário não possui empresa vinculada.");
			}

			var product = Product.Create(
				createProductDto.Name,
				createProductDto.Price,
				createProductDto.Amount,
				company.CompanyId
			);

			await _productRepository.CreateProduct(product);

			return Result<Product>.Success("Produto registrado com sucesso.", product);
		}
	}
}
