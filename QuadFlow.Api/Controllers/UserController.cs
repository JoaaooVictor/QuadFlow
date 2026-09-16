using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Users.Application.DTOs.UserDtos;
using Users.Application.Interfaces;

namespace QuadFlow.Api.Controllers
{
	[Route("api/user")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IRegisterUserUseCase _registerUserUseCase;
		private readonly IGetUserByIdUseCase _getUserByIdUseCase;
		public UserController(IRegisterUserUseCase userUseCase, IGetUserByIdUseCase getUserByIdUseCase)
		{
			_registerUserUseCase = userUseCase;
			_getUserByIdUseCase = getUserByIdUseCase;
		}

		[HttpPost]
		[Route("create-user")]
		public async Task<IActionResult> CreateUser(RegisterUserRequestDto request)
		{
			var response = await _registerUserUseCase.Execute(request);

			if (!response.Sucess)
			{
				return BadRequest(response.Message);
			}

			return Ok(response.Message);
		}

		[HttpGet]
		[Authorize]
		[Route("get-user-by-id")]
		public async Task<IActionResult> GetUserById(int id)
		{
			var response = await _getUserByIdUseCase.Execute(id);

			if (!response.Sucess)
			{
				return BadRequest(response.Message);
			}

			return Ok(response);
		}
	}
}
