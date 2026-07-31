namespace Products.Domain.ValueObjects
{
	public sealed record class Price
	{
		public double Value { get; internal set; }
		private Price() { }

		public Price(double value)
		{
			if (value <= 0)
			{
				throw new Exception("O valor do produto não pode ser menor ou igual a zero");
			}

			this.Value = value;
		}

	}
}
