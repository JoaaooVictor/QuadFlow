using Domain.Entities;

namespace Domain.Interfaces;

public interface IUserRepository
{
	Task<User> GetUserById(int id);
	Task<User> GetUserByEmail(string email);
	Task<List<User>> GetAll();
	Task UpdateUser(User user);
	Task RemoveUser(User user);
}
