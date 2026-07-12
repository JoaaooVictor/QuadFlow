using Companies.Domain.Entities;
using SharedKernel.ValueObjects;

namespace Companies.Domain.Interfaces
{
	public interface ICompanyRepository
	{
		Task<Company?> GetCompanyById(int id);
		Task<Company?> GetCompanyByUserId(int userId);
	}
}
