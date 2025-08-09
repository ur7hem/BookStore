using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NewBookStore.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using BookStoreRepositorys;

namespace NewBookStore.Controllers;

public class LoginController : Controller
{

    private readonly IUserRepository _user;
    public LoginController(IUserRepository user)
    {
        _user = user;
    }


    // GET: Login
    [HttpGet("/data")]
    [Authorize]
    public ActionResult Data([FromHeader] GetDataRequest headers)
    {
        //var username = User.Identity?.Name;
        Console.WriteLine("Accept: " + headers.Accept);
        Console.WriteLine("Authorization: " + headers.Authorization);

        return Ok(
            new
            {
                message = "Задолбало все"
            }
            );
    }

    // POST: Login
    [HttpPost]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {

        BookStoreDb.Db.User[] allUser = await _user.GetAllAsync();
        for (int i = 0; i < allUser.Length ; i++)
        {
            if (request.Email == allUser[i].Email)
            {

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (request.Password == allUser[i].Password)
                {
                    List<Claim> claims = new List<Claim> { new Claim(ClaimTypes.Email, request.Email) };
                    // создаем JWT-токен
                    JwtSecurityToken jwt = new JwtSecurityToken(
                            issuer: AuthOptions.ISSUER,
                            audience: AuthOptions.AUDIENCE,
                            claims: claims,
                            expires: DateTime.UtcNow.AddMinutes(2),
                            signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

                    string token = new JwtSecurityTokenHandler().WriteToken(jwt);

                    return Ok(
                        new
                        {
                            accessToken = token,
                            email  = request.Email
                        });
                }
            }
        }

        return Unauthorized();
    }
}

