using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SecureApi.Configuration;
using SecureApi.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime;
using System.Security.Claims;
using System.Text;

namespace SecureApi.Services
{
    public class JwtService(IOptions<JwtTokenSettings> settings) : IJwtService
    {
        private readonly JwtTokenSettings _settings = settings.Value;

        public string GenerateToken(User user)
        {
            var key = Encoding.UTF8.GetBytes(_settings.Key);
            var claims = new[]
            {
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, user.Role)
        };
            var token = new JwtSecurityToken(
                claims: claims,
                issuer: _settings.Issuer,
                audience: _settings.Audience,
                expires: DateTime.UtcNow.AddMinutes(_settings.ExpiryMinutes),
                //expires: Convert.ToDateTime(TimeSpan.FromMinutes(_settings.ExpiryMinutes)),
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool ValidateToken(string token)
        {
            var key = Encoding.UTF8.GetBytes(_settings.Key);
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = _settings.Issuer,
                    ValidateAudience = true,
                    ValidAudience = _settings.Audience
                }, out SecurityToken validatedToken);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
