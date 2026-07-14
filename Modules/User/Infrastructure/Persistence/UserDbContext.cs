using Microsoft.EntityFrameworkCore;
using Users.Domain.Entities;

namespace Users.Infrastructure.Persistence
{
	public class UserDbContext : DbContext
	{
		public UserDbContext(DbContextOptions options) : base(options) { }
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserDbContext).Assembly);
		}
	}
}
