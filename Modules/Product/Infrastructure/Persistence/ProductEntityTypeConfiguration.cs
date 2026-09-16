using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.Entities;
using Products.Domain.ValueObjects;

namespace Products.Infrastructure.Persistence
{
	public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder
				.ToTable("Product", schema: "Products");

			builder.
				HasKey(p => p.ProductId);

			builder
				.Property(p => p.ProductId)
				.ValueGeneratedOnAdd();

			builder.
				Property(p => p.Name)
				.HasMaxLength(100);

			builder
				.Property(p => p.Amount);

			builder
				.OwnsOne(x => x.Price, price =>
				{
					price.Property(x => x.Value)
							.HasPrecision(10, 2)
							.HasColumnName("Price");
				});

		}
	}
}
