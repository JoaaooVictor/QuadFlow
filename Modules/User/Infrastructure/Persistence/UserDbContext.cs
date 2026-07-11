using Users.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using QuadFlow.SharedKernel.Interfaces;
using System.Reflection;

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
