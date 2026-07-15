using Companies.Application.DTOs;
using Companies.Application.Interfaces;
using Companies.Domain.Entities;
using Companies.Domain.Interfaces;
using QuadFlow.SharedKernel.Abstractions;
using QuadFlow.SharedKernel.Interfaces;
using System.Net.Http.Headers;

namespace Companies.Application.UseCases
{
	public sealed class RegisterCompanyUseCase : IRegisterCompanyUseCase
	{
		private readonly ICompanyRepository _companyRepository;
		private readonly ICurrentUser _currentUser;

		public RegisterCompanyUseCase(ICompanyRepository companyRepository, ICurrentUser currentUser)
		{
			_companyRepository = companyRepository;
			_currentUser = currentUser;
		}

		public async Task<Result> Execute(RegisterCompanyRequestDto registerCompanyRequestDto)
		{
			if(_currentUser.UserId == 0)
			{
				return Result.Fail("Usuário não autenticado");
			}
				
			if (registerCompanyRequestDto is null)
			{
				return Result.Fail("Nenhuma empresa informada");
			}

			var userId = _currentUser.UserId;

			var company = Company.Create(
				registerCompanyRequestDto.Cnpj, 
				registerCompanyRequestDto.Name,
				userId
			);

			await _companyRepository.CreateCompany(company);

			return Result.Success("Empresa registrada com sucesso");
		}
	}
}
