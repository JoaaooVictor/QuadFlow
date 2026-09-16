using Companies.Domain.Entities;

namespace Companies.Application.Interfaces
{
	public interface ICompanyServices
	{
		Task<bool> ValidateIdCompany(int id, Company company);
	}
}
