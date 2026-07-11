using Contracts.DTOs;
using QuadFlow.SharedKernel.Abstractions;
using SharedKernel.ValueObjects;

namespace Contracts.Interfaces;

public interface IUserAuthenticationService
{
	Task<Result<UserAuthenticationDto>> GetUserByEmail(Email email);
	bool VerifyPassword(string password, string hashPassword);
}
