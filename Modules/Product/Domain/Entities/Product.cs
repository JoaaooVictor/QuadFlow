using Products.Domain.ValueObjects;

namespace Products.Domain.Entities
{
	public sealed class Product
	{
		public int ProductId { get; internal set; }
		public string Name { get; internal set; }
		public Price Price  { get; internal set; }
		public int Amount { get; internal set; }
	}
}
