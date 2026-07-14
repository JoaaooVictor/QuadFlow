using SharedKernel.ValueObjects;

namespace QuadFlow.SharedKernel.Interfaces
{
	public interface ICurrentUser
	{
		int UserId { get; }
		Email email { get; }
	}
}
