using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class User
{
	public int UserId { get; internal set; }
	public string Name { get; internal set; }
	public bool Active { get; internal set; }
	public Email Email { get; internal set; }
	public string Password { get; internal set; }
	public DateTime CreatedAt { get; internal set; }

	private User() { }
	public User(string name, Email email, string password)
	{
		this.Name = name;
		this.Email = email;
		this.Password = password;
		this.CreatedAt = DateTime.Now;
		this.Active = true;
	}
}
