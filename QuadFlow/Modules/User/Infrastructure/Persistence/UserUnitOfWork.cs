using QuadFlow.SharedKernel.Interfaces;

namespace Users.Infrastructure.Persistence
{
	public class UserUnitOfWork : IUnitOfWork
	{
		private readonly UserDbContext _userDbContext;

		public UserUnitOfWork(UserDbContext userDbContext)
		{
			_userDbContext = userDbContext;
		}

		public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			return await _userDbContext.SaveChangesAsync(cancellationToken);
		}
	}
}
