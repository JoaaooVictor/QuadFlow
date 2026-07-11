using Domain.Entities;
using SharedKernel.ValueObjects;

namespace Domain.Interfaces;

public interface IUserRepository
{
	Task<User?> GetUserById(int id);
	Task<User?> GetUserByEmail(Email email);
	Task<List<User>> GetAll();
	Task UpdateUser(User user);
	Task RemoveUser(User user);
	Task CreateUser(User user);
}
