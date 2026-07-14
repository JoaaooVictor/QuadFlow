using QuadFlow.SharedKernel.Interfaces;

namespace Companies.Infrastructure.Persistence
{
	public class CompanyUnitOfWork : IUnitOfWork
	{
		private readonly CompanyDbContext _companyDbContext;
		public CompanyUnitOfWork(CompanyDbContext companyDbContext)
		{
			_companyDbContext = companyDbContext;
		}

		public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			return await _companyDbContext.SaveChangesAsync(cancellationToken);
		}
	}
}
