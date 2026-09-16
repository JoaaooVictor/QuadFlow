using Companies.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Companies.Infrastructure.Persistence
{
	public class CompanyDbContext : DbContext
	{
		public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options) { }
		public DbSet<Company> Companies { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyDbContext).Assembly);
		}
	}
}
