using QuadFlow.SharedKernel.Abstractions;
using Users.Application.DTOs.UserDtos;
using Users.Application.Interfaces;
using Users.Domain.Interfaces;

namespace Users.Application.UseCases
{
	public class GetUserByIdUseCase : IGetUserByIdUseCase
	{
		private readonly IUserRepository _userRepository;

		public GetUserByIdUseCase(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public async Task<Result<GetUserByIdResponse>> Execute(int id)
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
	}
}
