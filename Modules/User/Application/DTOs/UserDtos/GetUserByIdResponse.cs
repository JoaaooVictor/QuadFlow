using Domain.ValueObjects;

namespace Application.DTOs.UserDtos
{
	public sealed record GetUserByIdResponse
	{
		public int UserId { get; internal set; }
		public string Name { get; internal set; }
		public bool Active { get; internal set; }
		public string Email { get; internal set; }
		public DateTime CreatedAt { get; internal set; }
	}
}
