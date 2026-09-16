namespace Companies.Domain.ValueObjects;

public sealed record Cnpj
{
	public string Value { get; }

	public Cnpj(string value)
	{
		if (!IsValid(value))
		{
			throw new ArgumentException("CNPJ inválido.");
		}

		Value = value;
	}

	private static bool IsValid(string value)
	{
		return value.Length == 14;
	}
}
