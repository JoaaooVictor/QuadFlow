namespace Users.Application.Interfaces
{
	public interface IPasswordHash
	{
		bool Verify(string password, string hash);
		string Hash(string password);
	}
}
