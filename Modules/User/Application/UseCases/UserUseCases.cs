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
		private readonly IPasswordHash _passwordHash;

		public UserUseCases(IUserRepository userRepository, IUnitOfWork unitOfWork, IPasswordHash passwordHash)
		{
			_userRepository = userRepository;
			_unitOfWork = unitOfWork;
			_passwordHash = passwordHash;
		}

		public async Task<Result<GetUserByIdResponse>> GetUserById(int id)
		{
			var userEntity = await _userRepository.GetUserById(id);

			if (userEntity is null)
			{
				return Result<GetUserByIdResponse>.Fail("Nenhum usuário encontrado");
			}

			var user = new GetUserByIdResponse
			{
				UserId = userEntity.UserId,
				Name = userEntity.Name,
				Email = userEntity.Email.Value,
				Active = userEntity.Active,
				CreatedAt = userEntity.CreatedAt
			};

			return Result<GetUserByIdResponse>.Success("Usuário encontrado", user);
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
