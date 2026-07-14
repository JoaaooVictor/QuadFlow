using Users.Application.DTOs.UserDtos;
using Users.Application.Interfaces;
using Users.Application.UseCases;
using Users.Domain.Entities;
using Users.Domain.Interfaces;
using SharedKernel.ValueObjects;
using Moq;
using QuadFlow.SharedKernel.Interfaces;

namespace Tests.UnitTests.Application
{
	public class UserTests
	{
		private readonly Mock<IUserRepository> _repository;
		private readonly Mock<IPasswordHash> _hasher;
		private readonly RegisterUserUseCase _useCase;

		public UserTests()
		{
			_repository = new();
			_hasher = new();

			_useCase = new RegisterUserUseCase(
				_repository.Object,
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
				Email = new Email("joao@email.com"),
				Password = "123456"
			};

			_repository
				.Setup(x => x.GetUserByEmail(request.Email))
				.ReturnsAsync((User)null);

			_hasher
				.Setup(x => x.Hash(request.Password))
				.Returns("senhaHash");

			// Act
			var result = await _useCase.Execute(request);

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
				Email = new Email("joao@gmail.com"),
				Password = "Teste123"
			};

			var existingUser = new User(
				"João",
				new Email("joao@gmail.com"),
				"hash"
			);

			_repository
				.Setup(r => r.GetUserByEmail(registerUserRequest.Email))
				.ReturnsAsync(existingUser);

			// Act
			var result = await _useCase.Execute(registerUserRequest);

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
