using Users.Application.DTOs.UserDtos;
using Users.Application.Interfaces;
using Users.Domain.Entities;
using Users.Domain.Interfaces;
using QuadFlow.SharedKernel.Abstractions;
using QuadFlow.SharedKernel.Interfaces;

namespace Users.Application.UseCases
{
	public class RegisterUserUseCase : IRegisterUserUseCase
	{
		private readonly IUserRepository _userRepository;
		private readonly IPasswordHash _passwordHash;

		public RegisterUserUseCase(IUserRepository userRepository, IPasswordHash passwordHash)
		{
			_userRepository = userRepository;
			_passwordHash = passwordHash;
		}

		public async Task<Result> Execute(RegisterUserRequestDto request)
		{
			var userExists = await _userRepository.GetUserByEmail(request.Email);

			if (userExists is not null)
			{
				return Result.Fail("Usuário com email informado existente");
			}

			var passwordHash = _passwordHash.Hash(request.Password);

			var user = new User(
				request.Name,
				request.Email,
				passwordHash
			);

			await _userRepository.CreateUser(user);

			return Result.Success("Usuário registrado com sucesso");
		}
	}
}
