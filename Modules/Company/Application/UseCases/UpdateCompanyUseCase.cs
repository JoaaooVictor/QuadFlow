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
		private readonly ICompanyServices _companyServices;

		public UpdateCompanyUseCase(ICompanyRepository companyRepository, ICurrentUser currentUser, ICompanyServices companyServices)
		{
			_companyRepository = companyRepository;
			_currentUser = currentUser;
			_companyServices = companyServices;
		}

		public async Task<Result> Execute(UpdateCompanyDto updateCompanyDto)
		{
			int userId = _currentUser.UserId;

			if (userId == 0)
			{
				return Result.Fail("Usuário não autenticado");
			}

			var company = await _companyRepository.GetCompanyByUserId(userId);

			if (company is null)
			{
				return Result.Fail("Usuário autenticado não possui vinculo com empresas.");
			}

			bool isValid = await _companyServices.ValidateIdCompany(updateCompanyDto.Id, company);

			if (!isValid)
			{
				return Result.Fail("Empresa autenticada, não é a mesma a ser atualizada.");
			}

			company.Update(updateCompanyDto.Cnpj, updateCompanyDto.Name);
			await _companyRepository.UpdateCompany(company);

			return Result.Success("Empresa atualiza com sucesso");
		}
	}
}
