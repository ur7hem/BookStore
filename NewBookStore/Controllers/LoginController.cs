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
    public ActionResult Login([FromBody] LoginRequest request)
    {

        var allUser = _user.GetAll();
        for (int i = 0; i < allUser.Length; i++)
        {
            if (request.Email == allUser[i].Email)
            {

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (request.Password == allUser[i].Password)
                {
                    var claims = new List<Claim> { new Claim(ClaimTypes.Email, request.Email) };
                    // создаем JWT-токен
                    var jwt = new JwtSecurityToken(
                            issuer: AuthOptions.ISSUER,
                            audience: AuthOptions.AUDIENCE,
                            claims: claims,
                            expires: DateTime.UtcNow.AddMinutes(2),
                            signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

                    var token = new JwtSecurityTokenHandler().WriteToken(jwt);

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

