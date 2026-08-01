namespace Products.Domain.ValueObjects
{
	public sealed record class Price
	{
		public decimal Value { get; }

		private Price() { }

		public Price(decimal value)
		{
			if (value <= 0)
				throw new Exception("O preço deve ser maior que zero.");

			Value = value;
		}
	}
}
