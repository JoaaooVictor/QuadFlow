using Companies.Domain.Entities;

namespace Companies.Domain.Interfaces
{
	public interface ICompanyRepository
	{
		Task<Company?> GetCompanyById(int id);
		Task<Company?> GetCompanyByUserId(int userId);
		Task CreateCompany(Company company);
	}
}
