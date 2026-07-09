using Application.DTOs;
using Application.Interfaces;
using Application.UseCases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuadFlow.Api.Controllers
{
	[Route("api/user")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserUseCases _userUseCases;
		public UserController(IUserUseCases userUseCase)
		{
			_userUseCases = userUseCase;
		}

		[HttpPost]
		public async Task<IActionResult> CreateUser(RegisterUserRequestDto request)
		{
			var response = await _userUseCases.Register(request);
			return Ok(response);
		}
	}
}
