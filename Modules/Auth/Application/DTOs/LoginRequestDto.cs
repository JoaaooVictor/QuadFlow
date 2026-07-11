using SharedKernel.ValueObjects;

namespace Auth.Application.DTOs;

public record class LoginRequestDto
{
	public Email Email { get; set; }
	public string Password { get; set; }
}
