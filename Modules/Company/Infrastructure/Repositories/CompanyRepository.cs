using Companies.Domain.Entities;
using Companies.Domain.Interfaces;
using Companies.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Companies.Infrastructure.Repositories
{
	public class CompanyRepository : ICompanyRepository
	{
		private readonly CompanyDbContext _companyDbContext;
		private readonly CompanyUnitOfWork _companyUnitOfWork;

		public CompanyRepository(CompanyDbContext companyDbContext, CompanyUnitOfWork companyUnitOfWork)
		{
			_companyDbContext = companyDbContext;
			_companyUnitOfWork = companyUnitOfWork;
		}

		public async Task CreateCompany(Company company)
		{
			await _companyDbContext.Companies.AddAsync(company);
			await _companyUnitOfWork.SaveChangesAsync();
		}

		public async Task<Company?> GetCompanyById(int id)
		{
			return await _companyDbContext.Companies.FirstOrDefaultAsync(c => c.CompanyId == id);
		}

		public async Task<Company?> GetCompanyByUserId(int userId)
		{
			throw new NotImplementedException();
		}
	}
}
