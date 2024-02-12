using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ToDoApi.Auth
{
    public class JwtTokenGenerator
    {
        public string Generate(string userId)
        {
            var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId),
            new Claim(ClaimTypes.Role, "api-user")
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("asaskljdabuivknaky12312312312312312312ashjkdbasjkda"));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "myapp.com",
                audience: "myapp.com",
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: credentials);

            var tokenGenerator = new JwtSecurityTokenHandler();
            var jwt = tokenGenerator.WriteToken(token);
            return jwt;
        }
    }
}
