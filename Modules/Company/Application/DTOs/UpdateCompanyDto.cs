using Companies.Domain.ValueObjects;

namespace Companies.Application.DTOs
{
	public class UpdateCompanyDto
	{
		public string Name { get; init; }
		public Cnpj Cnpj { get; init; }
		public DateTime CreatedAt { get; init; }

		public UpdateCompanyDto(string name, Cnpj cnpj, DateTime createdAt)
		{
			this.Name = name;
			this.Cnpj = cnpj;
			this.CreatedAt = createdAt;
		}

		public static UpdateCompanyDto Update(string name, Cnpj cnpj, DateTime createdAt)
		{
			return new UpdateCompanyDto(name, cnpj, createdAt);
		}
	}
}
