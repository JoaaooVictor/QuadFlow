using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly UserDbContext _dbContext;
		public UserRepository(UserDbContext context)
		{
			_dbContext = context;
		}

		public Task<List<User>> GetAll()
		{
			return _dbContext.Users.ToListAsync();
		}

		public async Task<User> GetUserByEmail(string email)
		{
			return await _dbContext.Users
				.Where(u => u.Email == email)
				.FirstAsync();
		}

		public async Task<User> GetUserById(int id)
		{
			return await _dbContext.Users
				.Where(u => u.UserId == id)
				.FirstAsync();
		}

		public Task RemoveUser(User user)
		{
			throw new NotImplementedException();
		}

		public Task UpdateUser(User user)
		{
			throw new NotImplementedException();
		}
	}
}
