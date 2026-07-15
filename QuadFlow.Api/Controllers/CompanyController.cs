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
		private readonly IRegisterCompanyUseCase _useCase;

		public CompanyController(IRegisterCompanyUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPost]
		[Route("register-company")]
		public async Task<IActionResult> RegisterCompany(RegisterCompanyRequestDto registerCompanyRequestDto)
		{
			var response = await _useCase.Execute(registerCompanyRequestDto);

			if (!response.Sucess)
			{
				return BadRequest(response);
			}

			return Ok(response);
		}
	}
}
