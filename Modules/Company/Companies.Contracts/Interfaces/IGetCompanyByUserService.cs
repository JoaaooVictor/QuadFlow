using Companies.Contracts.DTOs;

namespace Companies.Contracts.Interfaces
{
	public interface IGetCompanyByUserService
	{
		Task<ResponseGetCompanyByUserDto> GetCompanyByUserId(int userId);
	}
}
