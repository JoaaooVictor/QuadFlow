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

		public async Task<Result> Execute(UpdateCompanyDto updateCompanyDto)
		{
			int userId = _currentUser.UserId;

			if (userId == 0)
			{
				return Result.Fail("Usuário não autenticado");
			}

			var company = await _companyRepository.GetCompanyByUserId(userId);
		}
	}
}
