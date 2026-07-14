using Companies.Domain.Entities;
using Companies.Domain.Interfaces;
using Companies.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Companies.Infrastructure.Repositories
{
	public class CompanyRepository : ICompanyRepository
	{
		private readonly CompanyDbContext _companyDbContext;

		public CompanyRepository(CompanyDbContext companyDbContext)
		{
			_companyDbContext = companyDbContext;
		}

		public async Task CreateCompany(Company company)
		{
			await _companyDbContext.Companies.AddAsync(company);
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
