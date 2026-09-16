using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Products.Application.DTOs;
using Products.Application.Interfaces;

namespace QuadFlow.Api.Controllers
{
	[ApiController]
	[Route("api/product")]
	[Authorize]
	public class ProductController : ControllerBase
	{
		private readonly ICreateProductUseCase _createProductUseCase;
		private readonly IGetAllProductsUseCase _getAllProductsUseCase;

		public ProductController(ICreateProductUseCase createProductUseCase, IGetAllProductsUseCase getAllProductsUseCase)
		{
			_createProductUseCase = createProductUseCase;
			_getAllProductsUseCase = getAllProductsUseCase;
		}

		[HttpPost]
		[Route("create-product")]
		public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
		{
			var response = await _createProductUseCase.Execute(createProductDto);

			if (!response.Sucess)
			{
				return BadRequest(response);
			}

			return Ok(response);
		}

		[HttpGet]
		[Route("get-all-products")]
		public async Task<IActionResult> GetAllProducts()
		{
			var response = await _getAllProductsUseCase.Execute();

			if (!response.Sucess)
			{
				return BadRequest(response);
			}

			return Ok(response);
		}
	}
}
