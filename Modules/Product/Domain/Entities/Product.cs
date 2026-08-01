using Products.Domain.ValueObjects;

namespace Products.Domain.Entities
{
	public sealed class Product
	{
		public int ProductId { get; internal set; }
		public int CompanyId { get; internal set; }
		public string Name { get; internal set; }
		public Price Price { get; internal set; }
		public int Amount { get; internal set; }
		private Product() { }
		public Product(string name, Price price, int amount, int companyId)
		{
			this.Name = name;
			this.Price = price;
			this.Amount = amount;
			this.CompanyId = companyId;
		}

		public static Product Create(string name, Price price, int amount, int companyId)
		{
			return new Product(name, price, amount, companyId);
		}
	}
}
