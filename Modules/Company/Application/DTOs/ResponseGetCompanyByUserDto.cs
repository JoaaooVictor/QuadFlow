using Companies.Domain.ValueObjects;
using System.Runtime.InteropServices;

namespace Companies.Application.DTOs
{
	public sealed class ResponseGetCompanyByUserDto
	{
		public int CompanyId { get; init; }
		public string Name { get; init; }
		public Cnpj Cnpj { get; init; }
		public DateTime CreatedAt { get; init; }

		public ResponseGetCompanyByUserDto(int companyId, string name, Cnpj cnpj, DateTime createdAt)
		{
			this.CompanyId = companyId;
			this.Name = name;
			this.Cnpj = cnpj;
			this.CreatedAt = createdAt;
		}

		public static ResponseGetCompanyByUserDto Create(int companyId, string name, Cnpj cnpj, DateTime createdAt)
		{
			return new ResponseGetCompanyByUserDto(companyId, name, cnpj, createdAt);
		}
	}
}
