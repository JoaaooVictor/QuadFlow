using Products.Domain.ValueObjects;

namespace Products.Application.DTOs
{
	public sealed class CreateProductDto
	{
		public string Name { get; init; }
		public int Amount { get; set; }
		public Price Price { get; set; }
	}
}
