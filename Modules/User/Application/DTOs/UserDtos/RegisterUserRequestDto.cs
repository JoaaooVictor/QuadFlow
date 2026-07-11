using SharedKernel.ValueObjects;

namespace Application.DTOs.UserDtos
{
	public sealed class RegisterUserRequestDto
	{
		public string Name { get; init; }
		public Email Email { get; init; }
		public string Password { get; init; }
	}
}
