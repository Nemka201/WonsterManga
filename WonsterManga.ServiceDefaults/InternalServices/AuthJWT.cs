using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WonsterManga.Data.Entities;
using WonsterManga.Domain.Entities;

namespace WonsterManga.ServiceDefaults.InternalServices
{
    public class AuthJWT : IAuthJWT
    {
        private readonly JwtSettings _jwtSettings;
        public AuthJWT(JwtSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public string BuildToken(User user)
        {
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            var expiresToken = DateTime.UtcNow.AddHours(_jwtSettings.LifeTime);
            var header = new JwtHeader(signingCredentials);
            var claims = new Claim[]
            {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Name),
            new Claim(ClaimTypes.Role, user.Role.Name)
            };

            var payload = new JwtPayload(
                    issuer: _jwtSettings.Issuer,
                    audience: _jwtSettings.Audience,
                    claims: claims,
                    notBefore: DateTime.UtcNow,
                    expires: expiresToken);

            var token = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
        public static Claim[] GetClaims(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = tokenHandler.ReadJwtToken(token);
            var claims = jwtToken.Claims.ToArray();
            return claims;
        }
    }
}
