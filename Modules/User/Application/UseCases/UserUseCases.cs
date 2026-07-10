using Application.DTOs.UserDtos;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using QuadFlow.SharedKernel.Abstractions;
using QuadFlow.SharedKernel.Interfaces;

namespace Application.UseCases
{
	public class UserUseCases : IUserUseCases
	{
		private readonly IUserRepository _userRepository;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IJwtProvider _jwtProvider;
		private readonly IPasswordHash _passwordHash;

		public UserUseCases(IUserRepository userRepository, IUnitOfWork unitOfWork, IJwtProvider jwtProvider, IPasswordHash passwordHash)
		{
			_userRepository = userRepository;
			_unitOfWork = unitOfWork;
			_jwtProvider = jwtProvider;
			_passwordHash = passwordHash;
		}

		public async Task<Result<User>> GetUserById(int id)
		{
			var user = await _userRepository.GetUserById(id);

			if (user is null)
			{
				return Result<User>.Fail("Usuário não encontrado");
			}

			return Result<User>.Success("Usuário encontrado", user);
		}

		public async Task<Result> Register(RegisterUserRequestDto request)
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
			await _unitOfWork.SaveChangesAsync();

			return Result.Success("Usuário registrado com sucesso");
		}
	}
}
