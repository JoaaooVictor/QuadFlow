using Companies.Domain.ValueObjects;

namespace Companies.Application.DTOs
{
	public record class UpdateCompanyDto
	{
		public int Id { get; init; }
		public string Name { get; init; }
		public Cnpj Cnpj { get; init; }
		public DateTime CreatedAt { get; init; }

		public UpdateCompanyDto(int id, string name, Cnpj cnpj, DateTime createdAt)
		{
			this.Id = id;
			this.Name = name;
			this.Cnpj = cnpj;
			this.CreatedAt = createdAt;
		}

		public static UpdateCompanyDto Update(int id, string name, Cnpj cnpj, DateTime createdAt)
		{
			return new UpdateCompanyDto(id, name, cnpj, createdAt);
		}
	}
}
