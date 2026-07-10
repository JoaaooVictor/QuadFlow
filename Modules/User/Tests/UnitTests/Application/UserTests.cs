using Application.DTOs.UserDtos;
using Application.Interfaces;
using Application.UseCases;
using Domain.Entities;
using Domain.Interfaces;
using Moq;
using QuadFlow.SharedKernel.Interfaces;

namespace Tests.UnitTests.Application
{
	public class UserTests
	{
		private readonly Mock<IUserRepository> _repository;
		private readonly Mock<IPasswordHash> _hasher;
		private readonly Mock<IJwtProvider> _jwt;
		private readonly Mock<IUnitOfWork> _unitOfWork;
		private readonly UserUseCases _useCase;

		public UserTests()
		{
			_repository = new();
			_hasher = new();
			_jwt = new();
			_unitOfWork = new();

			_useCase = new UserUseCases(
				_repository.Object,
				_unitOfWork.Object,
				_jwt.Object,
				_hasher.Object
			);
		}

		[Fact]
		public async Task DeveRegistrarUsuarioQuandoEmailNaoExistir()
		{
			// Arrange
			var request = new RegisterUserRequestDto
			{
				Name = "João",
				Email = "joao@email.com",
				Password = "123456"
			};

			_repository
				.Setup(x => x.GetUserByEmail(request.Email))
				.ReturnsAsync((User)null);

			_hasher
				.Setup(x => x.Hash(request.Password))
				.Returns("senhaHash");

			// Act
			var result = await _useCase.Register(request);

			// Assert
			Assert.True(result.Sucess);
			Assert.Equal("Usuário registrado com sucesso", result.Message);

			_repository.Verify(
				x => x.CreateUser(It.IsAny<User>()),
				Times.Once
			);
		}

		[Fact]
		public async Task NaoDeveRegistrarUsuarioQuandoEmailExistir()
		{
			// Arrange
			var registerUserRequest = new RegisterUserRequestDto
			{
				Name = "João",
				Email = "joao@gmail.com",
				Password = "Teste123"
			};

			var existingUser = new User(
				"João",
				"joao@gmail.com",
				"hash"
			);

			_repository
				.Setup(r => r.GetUserByEmail(registerUserRequest.Email))
				.ReturnsAsync(existingUser);

			// Act
			var result = await _useCase.Register(registerUserRequest);

			// Assert
			Assert.False(result.Sucess);

			Assert.Equal(
				"Usuário com email informado existente",
				result.Message
			);

			_repository.Verify(
				r => r.CreateUser(It.IsAny<User>()),
				Times.Never
			);
		}
	}
}
