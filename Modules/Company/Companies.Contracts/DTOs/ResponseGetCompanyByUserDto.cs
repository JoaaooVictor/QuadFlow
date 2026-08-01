using Companies.Domain.ValueObjects;

namespace Companies.Contracts.DTOs
{
	public record class ResponseGetCompanyByUserDto
	{
		public int CompanyId { get; init; }
		public string Name { get; init; }
		public Cnpj Cnpj { get; init; }

		public ResponseGetCompanyByUserDto(int companyId, string name, Cnpj cnpj)
		{
			this.CompanyId = companyId;
			this.Name = name;
			this.Cnpj = cnpj;
		}
	}
}
