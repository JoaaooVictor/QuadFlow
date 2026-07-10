using Application.Interfaces;
using Application.Utils;
using Domain.Entities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Authentication
{
	public class JwtProvider : IJwtProvider
	{
		private readonly JwtConfig _jwtConfig;
		public JwtProvider(IOptions<JwtConfig> jwtConfig)
		{
			_jwtConfig = jwtConfig.Value;
		}
		public async Task<string> GenerateToken(User user)
		{
			var key = Encoding.UTF8.GetBytes(_jwtConfig.Key);
			var issuer = _jwtConfig.Issuer;
			var audience = _jwtConfig.Audience;
			var expireMinutes = _jwtConfig.ExpireMinutes;

			var claims = new[]
			{
				new Claim(JwtRegisteredClaimNames.Email, user.Email.ToString()),
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
				new Claim(ClaimTypes.Expired, DateTime.UtcNow.AddMinutes(expireMinutes).ToString())
			};

			var token = new JwtSecurityToken(
				issuer,
				audience,
				claims,
				expires: DateTime.UtcNow.AddMinutes(expireMinutes),
				signingCredentials: new SigningCredentials(
					new SymmetricSecurityKey(key),
					SecurityAlgorithms.HmacSha256)
			);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}
	}
}
