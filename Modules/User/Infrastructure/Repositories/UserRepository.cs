using Users.Domain.Entities;
using Users.Domain.Interfaces;
using Users.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using SharedKernel.ValueObjects;
using QuadFlow.SharedKernel.Interfaces;

namespace Users.Infrastructure.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly UserDbContext _dbContext;
		private readonly IUnitOfWork _unitOfWork;
		public UserRepository(UserDbContext context, IUnitOfWork unitOfWork)
		{
			_dbContext = context;
			_unitOfWork = unitOfWork;
		}

		public async Task CreateUser(User user)
		{
			await _dbContext.Users.AddAsync(user);
			await _unitOfWork.SaveChangesAsync();
		}

		public async Task<List<User>> GetAll()
		{
			return await _dbContext.Users.ToListAsync();
		}

		public async Task<User?> GetUserByEmail(Email email)
		{
			return await _dbContext.Users
				.FirstOrDefaultAsync(u => u.Email.Value == email.Value);
		}

		public async Task<User?> GetUserById(int id)
		{
			return await _dbContext.Users
				.FirstOrDefaultAsync(u => u.UserId == id);
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
