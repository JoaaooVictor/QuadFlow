using Products.Domain.Entities;

namespace Products.Domain.Interfaces
{
	public interface IProductRepository
	{
		Task CreateProduct(Product product);
		Task<Product?> GetProductById(int id);
	}
}
