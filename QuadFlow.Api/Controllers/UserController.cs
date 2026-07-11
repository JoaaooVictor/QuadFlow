using Users.Application.DTOs.UserDtos;
using Users.Application.Interfaces;
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
		[Route("create-user")]
		public async Task<IActionResult> CreateUser(RegisterUserRequestDto request)
		{
			var response = await _userUseCases.Register(request);

			if (!response.Sucess)
			{
				return BadRequest(response.Message);
			}

			return Ok(response.Message);
		}

		[HttpGet]
		[Route("get-user-by-id")]
		public async Task<IActionResult> GetUserById(int id)
		{
			var response = await _userUseCases.GetUserById(id);

			if (!response.Sucess)
			{
				return BadRequest(response.Message);
			}

			return Ok(response);
		}
	}
}
