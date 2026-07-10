using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
	public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder
				.HasKey(u => u.UserId);

			builder
				.Property(u => u.UserId)
				.ValueGeneratedOnAdd();

			builder
				.ToTable("Users", schema: "Users");

			builder
				.Property(u => u.Name)
				.HasColumnType("VARCHAR(100)");

			builder
				.Property(u => u.Password)
				.HasColumnType("VARCHAR(100)");

			builder
				.OwnsOne(x => x.Email, email => { email.Property(x => x.Value).HasColumnName("Email"); });
		}
	}
}
