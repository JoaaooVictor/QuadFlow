using Users.Application.Interfaces;
using Users.Contracts.DTOs;
using Users.Contracts.Interfaces;
using Users.Domain.Interfaces;
using QuadFlow.SharedKernel.Abstractions;
using SharedKernel.ValueObjects;

namespace Users.Application.Services
{
	public class UserAuthenticationService : IUserAuthenticationService
	{
		private readonly IUserRepository _userRepository;
		private readonly IPasswordHash _passwordHash;

		public UserAuthenticationService(IUserRepository repository, IPasswordHash passwordHash)
		{
			_userRepository = repository;
			_passwordHash = passwordHash;
		}

		public async Task<Result<UserAuthenticationDto>> GetUserByEmail(Email email)
		{
			var user = await _userRepository.GetUserByEmail(email);

			if (user is null)
			{
				return Result<UserAuthenticationDto>.Fail("Nenhum usuário encontrado");
			}

			var userAuthentication = new UserAuthenticationDto(
			   user.UserId,
			   user.Email,
			   user.Password,
			   user.Active
			);

			return Result<UserAuthenticationDto>.Success("Usuário encontrado", userAuthentication);
		}

		public bool VerifyPassword(string password, string hashPassword)
		{
			return _passwordHash.Verify(password, hashPassword);
		}
	}
}
