using SharedKernel.ValueObjects;

namespace Contracts.DTOs;

public class UserAuthenticationDto
{
	public Email Email { get; set; }
	public string Password { get; set; }
	public int UserId { get; internal set; }
	public bool Active { get; internal set; }

	public UserAuthenticationDto(int userId, Email email, string password, bool active)
	{
		UserId = userId;
		Email = email;
		Password = password;
		Active = active;
	}
}
