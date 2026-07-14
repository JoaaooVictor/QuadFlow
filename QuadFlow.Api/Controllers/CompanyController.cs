using Companies.Application.DTOs;
using Companies.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace QuadFlow.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
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
