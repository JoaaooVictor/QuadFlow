using QuadFlow.SharedKernel.Interfaces;

namespace Products.Infrastructure.Persistence
{
	public class ProductUnitOfWork : IUnitOfWork
	{
		private readonly ProductDbContext _productDbContext;

		public ProductUnitOfWork(ProductDbContext productDbContext)
		{
			_productDbContext = productDbContext;
		}

		public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			return await _productDbContext.SaveChangesAsync(cancellationToken);
		}
	}
}
