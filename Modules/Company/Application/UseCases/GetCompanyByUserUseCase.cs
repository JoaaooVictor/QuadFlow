using Companies.Application.DTOs;
using Companies.Application.Interfaces;
using Companies.Domain.Interfaces;
using QuadFlow.SharedKernel.Abstractions;
using QuadFlow.SharedKernel.Interfaces;

namespace Companies.Application.UseCases
{
	public sealed class GetCompanyByUserUseCase : IGetCompanyByUserUseCase
	{
		private readonly ICompanyRepository _companyRepository;
		private readonly ICurrentUser _currentUser;
		public GetCompanyByUserUseCase(ICompanyRepository companyRepository, ICurrentUser currentUser)
		{
			_companyRepository = companyRepository;
			_currentUser = currentUser;
		}

		public async Task<Result<ResponseGetCompanyByUserDto>> Execute()
		{
			if (_currentUser.UserId == 0)
			{
				return Result<ResponseGetCompanyByUserDto>.Fail("Nenhum usuário autenticado");
			}

			var userId = _currentUser.UserId;
			var company = await _companyRepository.GetCompanyByUserId(userId);

			if (company is null)
			{
				return Result<ResponseGetCompanyByUserDto>.Fail("Nenhuma empresa vinculada ao usuário");
			}

			var responseCompany = ResponseGetCompanyByUserDto.Create(
				company.CompanyId,
				company.Name,
				company.Cnpj,
				company.CreateAt
			);

			return Result<ResponseGetCompanyByUserDto>.Success("Empresa encontrada", responseCompany);
		}
	}
}
