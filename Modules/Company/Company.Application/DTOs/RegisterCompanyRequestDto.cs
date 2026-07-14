using Companies.Domain.ValueObjects;

namespace Companies.Application.DTOs
{
	public record class RegisterCompanyRequestDto
	{
		public string Name { get; init; }
		public Cnpj Cnpj { get; init; }
	}
}
