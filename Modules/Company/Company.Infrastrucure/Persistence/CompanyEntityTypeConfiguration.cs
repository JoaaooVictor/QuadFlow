using Companies.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Companies.Infrastructure.Persistence
{
	public class CompanyEntityTypeConfiguration : IEntityTypeConfiguration<Company>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Company> builder)
		{
			throw new NotImplementedException();
		}
	}
}
