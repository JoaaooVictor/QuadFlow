using Companies.Application.DTOs;
using Companies.Application.Interfaces;
using Companies.Domain.Interfaces;
using QuadFlow.SharedKernel.Abstractions;
using QuadFlow.SharedKernel.Interfaces;

namespace Companies.Application.UseCases
{
	public sealed class UpdateCompanyUseCase : IUpdateCompanyUseCase
	{
		private readonly ICompanyRepository _companyRepository;
		private readonly ICurrentUser _currentUser;

		public UpdateCompanyUseCase(ICompanyRepository companyRepository, ICurrentUser currentUser)
		{
			_companyRepository = companyRepository;
			_currentUser = currentUser;
		}

		public Task<Result> Execute(UpdateCompanyDto updateCompanyDto)
		{
			throw new NotImplementedException();
		}
	}
}
