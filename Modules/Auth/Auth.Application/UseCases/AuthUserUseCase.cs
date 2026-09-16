using Auth.Application.DTOs;
using Auth.Application.Interfaces;
using Users.Contracts.Interfaces;
using QuadFlow.SharedKernel.Abstractions;
using SharedKernel.ValueObjects;

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
			if(loginRequest.Email is null)
			{
				return Result<LoginResponseDto>.Fail("Informe um e-mail para o login.");
			}

			var email = Email.Create(loginRequest.Email);
			var response = await _userAuthentication.GetUserByEmail(email);

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
