using Companies.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Companies.Infrastructure.Persistence
{
	public class CompanyEntityTypeConfiguration : IEntityTypeConfiguration<Company>
	{
		public void Configure(EntityTypeBuilder<Company> builder)
		{
			builder
				.ToTable("Company", schema: "Companies");

			builder
				.Property(c => c.CompanyId)
				.ValueGeneratedOnAdd();

			builder
				.Property(c => c.Name)
				.HasMaxLength(150);
		}
	}
}
