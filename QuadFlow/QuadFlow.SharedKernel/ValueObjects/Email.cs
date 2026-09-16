namespace SharedKernel.ValueObjects;

public sealed record class Email
{
	public string Value { get; internal set; }
	private Email() { }

	public Email(string value)
	{
		if(string.IsNullOrEmpty(value))
		{
			throw new Exception("E-mail Obrigatório");
		}
		
		Value = value.ToLower();
	}

	public override string ToString()
	{
		return this.Value.ToString();
	}

	public static Email Create(string email)
	{
		return new Email(email);
	}
}
