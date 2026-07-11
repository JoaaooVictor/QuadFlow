using Auth.Application.DTOs;
using Auth.Application.Interfaces;
using Users.Contracts.Interfaces;
using QuadFlow.SharedKernel.Abstractions;

namespace Auth.Application.UseCases
{
	public class AuthUserUseCase : IAuthUserUseCase
	{
		private readonly IUserAuthenticationService _userAuthentication;
		private readonly IJwtProvider _jwtProvider;

		public AuthUserUseCase(IUserAuthenticationService userAuthentication, IJwtProvider jwtProvider)
		{
			_userAuthentication = userAuthentication;
			_jwtProvider = jwtProvider;
		}

		public async Task<Result<LoginResponseDto>> LoginUser(LoginRequestDto loginRequest)
		{
			var response = await _userAuthentication.GetUserByEmail(loginRequest.Email);

			if (!response.Sucess)
			{
				return Result<LoginResponseDto>.Fail(response.Message);
			}

			var user = response.Value!;
			bool passwordAuthenticated = _userAuthentication.VerifyPassword(loginRequest.Password, user.Password);

			if (!passwordAuthenticated)
			{
				return Result<LoginResponseDto>.Fail("Senha incorreta!");
			}

			var token = await _jwtProvider.GenerateToken(user);

			var loginResponse = new LoginResponseDto
			{
				Token = token
			};
	
			return Result<LoginResponseDto>.Success("Usuário autenticado com sucesso", loginResponse);
		}
	}
}
