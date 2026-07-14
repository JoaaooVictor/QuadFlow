using Companies.Domain.ValueObjects;

namespace Companies.Domain.Entities
{
	public sealed class Company
	{
		public Cnpj Cnpj { get; internal set; }
		public int UserId { get; internal set; }
		public string Name { get; internal set; }
		public int CompanyId { get; internal set; }
		public DateTime CreateAt { get; internal set; }
		public DateTime UpdateAt { get; internal set; }

		private Company(){}
		public Company(Cnpj cnpj, string name, int userId)
		{
			this.UserId = userId;
			this.Cnpj = cnpj;
			this.Name = name;
			this.CreateAt = DateTime.Now;
		}

		public static Company Create(Cnpj cnpj, string name, int userId)
		{
			return new Company(cnpj, name, userId);
		}
	}
}
