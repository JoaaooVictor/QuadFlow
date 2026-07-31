using Microsoft.EntityFrameworkCore;
using Products.Domain.Entities;
using Products.Domain.Interfaces;
using Products.Infrastructure.Persistence;

namespace Products.Infrastructure.Repositories
{
	public sealed class ProductRepository : IProductRepository
	{
		private readonly ProductDbContext _productDbContext;
		private readonly ProductUnitOfWork _productUnitOfWork;
		public ProductRepository(ProductDbContext productDbContext, ProductUnitOfWork productUnitOfWork)
		{
			_productDbContext = productDbContext;
			_productUnitOfWork = productUnitOfWork;
		}

		public async Task CreateProduct(Product product)
		{
			await _productDbContext.Products.AddAsync(product);
			await _productUnitOfWork.SaveChangesAsync();
		}

		public async Task<Product?> GetProductById(int id)
		{
			return await _productDbContext.Products.FirstOrDefaultAsync(p => p.ProductId == id);
		}
	}
}
