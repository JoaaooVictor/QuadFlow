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
}
