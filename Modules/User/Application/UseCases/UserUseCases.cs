using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using QuadFlow.SharedKernel.Interfaces;

namespace Application.UseCases
{
	public class UserUseCases : IUserUseCases
	{
		private readonly IUserRepository _userRepository;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IJwtProvider _jwtProvider;

		public UserUseCases(IUserRepository userRepository, IUnitOfWork unitOfWork, IJwtProvider jwtProvider)
		{
			_userRepository = userRepository;
			_unitOfWork = unitOfWork;
			_jwtProvider = jwtProvider;
		}

		public async Task<RegisterUserResponseDto> Register(RegisterUserRequestDto request)
		{
			var userExists = await _userRepository.GetUserByEmail(request.Email);

			if (userExists is not null)
			{
				throw new Exception("E-mail já existente.");
			}

			var user = new User(
				request.Name,
				request.Email,
				request.Password
			);

			await _userRepository.CreateUser(user);
			await _unitOfWork.SaveChangesAsync();

			var token  = await _jwtProvider.GenerateToken(user);

			return new RegisterUserResponseDto
			{
				Token = token
			};
		}
	}
}
