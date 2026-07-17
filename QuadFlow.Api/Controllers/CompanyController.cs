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

		public CompanyController(IRegisterCompanyUseCase registerCompanyUseCase, IGetCompanyByUserUseCase getCompanyByUserUseCase)
		{
			_registerCompanyUseCase = registerCompanyUseCase;
			_getCompanyByUserUseCase = getCompanyByUserUseCase;
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
