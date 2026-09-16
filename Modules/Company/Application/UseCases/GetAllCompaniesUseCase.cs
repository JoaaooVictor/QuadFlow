using Companies.Application.Interfaces;
using Companies.Domain.Entities;
using Companies.Domain.Interfaces;
using QuadFlow.SharedKernel.Abstractions;

namespace Companies.Application.UseCases
{
	public class GetAllCompaniesUseCase : IGetAllCompaniesUseCase
	{
		private readonly ICompanyRepository _companyRepository;

		public GetAllCompaniesUseCase(ICompanyRepository companyRepository)
		{
			_companyRepository = companyRepository;
		}

		public async Task<Result<List<Company>>> Execute()
		{
			return Result<List<Company>>.Success("", await _companyRepository.GetAllCompanies());
		}
	}
}
