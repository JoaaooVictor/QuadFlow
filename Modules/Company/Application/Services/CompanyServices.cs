using Companies.Application.Interfaces;
using Companies.Domain.Entities;

namespace Companies.Application.Services
{
	public class CompanyServices : ICompanyServices
	{
		public async Task<bool> ValidateIdCompany(int id, Company company)
		{
			if(id != company.CompanyId)
			{
				return false;
			}

			return true;
		}
	}
}
