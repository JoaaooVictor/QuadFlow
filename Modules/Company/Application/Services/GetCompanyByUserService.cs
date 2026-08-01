using Companies.Contracts.DTOs;
using Companies.Contracts.Interfaces;
using Companies.Domain.Interfaces;

namespace Companies.Application.Services
{
	public class GetCompanyByUserService : IGetCompanyByUserService
	{
		private readonly ICompanyRepository _companyRepository;

		public GetCompanyByUserService(ICompanyRepository companyRepository)
		{
			_companyRepository = companyRepository;
		}

		public async Task<ResponseGetCompanyByUserDto> GetCompanyByUserId(int userId)
		{
			var company = await _companyRepository.GetCompanyByUserId(userId);

			if(company is null)
			{
				return null!;
			}

			return new ResponseGetCompanyByUserDto(
				company.CompanyId,
				company.Name,
				company.Cnpj
			);
		}
	}
}
