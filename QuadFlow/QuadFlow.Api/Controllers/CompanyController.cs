using Companies.Application.DTOs;
using Companies.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace QuadFlow.Api.Controllers
{
	[Authorize]
	[ApiController]
	[Route("api/company")]
	public class CompanyController : ControllerBase
	{
		private readonly IRegisterCompanyUseCase _registerCompanyUseCase;
		private readonly IGetCompanyByUserUseCase _getCompanyByUserUseCase;
		private readonly IGetAllCompaniesUseCase _getAllCompaniesUseCase;

		public CompanyController(IRegisterCompanyUseCase registerCompanyUseCase, IGetCompanyByUserUseCase getCompanyByUserUseCase, IGetAllCompaniesUseCase getAllCompaniesUseCase)
		{
			_registerCompanyUseCase = registerCompanyUseCase;
			_getCompanyByUserUseCase = getCompanyByUserUseCase;
			_getAllCompaniesUseCase = getAllCompaniesUseCase;
		}

		[HttpPost]
		[Route("register-company")]
		public async Task<IActionResult> RegisterCompany(RegisterCompanyRequestDto registerCompanyRequestDto)
		{
			var response = await _registerCompanyUseCase.Execute(registerCompanyRequestDto);

			if (!response.Sucess)
			{
				return BadRequest(response);
			}

			return Ok(response);
		}

		[HttpGet]
		[Route("get-all-companies")]
		public async Task<IActionResult> GetAllCompanies()
		{
			var response = await _getAllCompaniesUseCase.Execute();

			if (!response.Sucess)
			{
				return BadRequest(response);
			}

			return Ok(response);
		}

		[HttpGet]
		[Route("get-company-by-user-authenticaded")]
		public async Task<IActionResult> GetCompanyByUserAuthenticated()
		{
			var response = await _getCompanyByUserUseCase.Execute();

			if (!response.Sucess)
			{
				return BadRequest(response);
			}

			return Ok(response);
		}

		[HttpPut]
		[Route("update-company")]
		public async Task<IActionResult> UpdateCompany()
		{
			var response = await _getCompanyByUserUseCase.Execute();

			if (!response.Sucess)
			{
				return BadRequest(response);
			}

			return Ok(response);
		}
	}
}
