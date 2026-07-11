using Auth.Application.DTOs;
using Auth.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace QuadFlow.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthUserUseCase _authUserUseCase;
		public AuthController(IAuthUserUseCase authUserUseCase)
		{
			_authUserUseCase = authUserUseCase;
		}

		[HttpPost]
		public async Task<IActionResult> AuthUser(LoginRequestDto loginRequest)
		{
			var response = await _authUserUseCase.LoginUser(loginRequest);

			if (!response.Sucess)
			{
				return BadRequest(response.Message);
			}

			return Ok(response.Message);
		}
	}
}
