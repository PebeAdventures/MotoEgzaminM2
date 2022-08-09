using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MotoEgzaminM2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthTokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly string adminRole = "Admin";
        private readonly string userRole = "User";
        private readonly string userLogin = "user";
        private readonly string userPassword = "user";
        private readonly string adminLogin = "admin";
        private readonly string adminPassword = "admin";

        public AuthTokenController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        public async Task<IActionResult> Post(string username, string pass)
        {



            bool userIsAdmin = username == adminLogin && adminPassword == pass;
            bool userIsUser = username == userLogin && userPassword == pass;
            if (userIsAdmin || userIsUser)
            {
                var claims = new[] {

                        new Claim("DisplayName", username),
                        new Claim("UserName", username),
                        new Claim(ClaimTypes.Role, userIsAdmin?adminRole:userRole)
                    };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:Key").Value));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(20),
                    signingCredentials: signIn);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            else return BadRequest("wrong username or password");
        }

    }
}
