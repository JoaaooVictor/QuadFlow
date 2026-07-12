using Companies.Domain.ValueObjects;

namespace Companies.Domain.Entities
{
	public sealed class Company
	{
		public Cnpj CNPJ { get; internal set; }
		public string Name { get; internal set; }
		public int CompanyId { get; internal set; }
		public DateTime CreateAt { get; internal set; }
		public DateTime UpdateAt { get; internal set; }

		private Company() { }
		public Company(Cnpj cnpj, string name, int companyId, DateTime createAt, DateTime updateAt)
		{
			CNPJ = cnpj;
			Name = name;
			CompanyId = companyId;
			CreateAt = createAt;
			UpdateAt = updateAt;
		}
	}
}
