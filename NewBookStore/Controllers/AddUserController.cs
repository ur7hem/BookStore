using BookStoreRepositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewBookStore.Models;
using BookStoreDb.Db;


namespace NewBookStore.Controllers;

public class AddUserController : Controller
{

    private readonly IUserRepository _user;
    public AddUserController(IUserRepository user)
    {
        _user = user;
    }


    [HttpPost]
    public async Task<IActionResult> addUser([FromBody] AddUser addingUser)
    {
        await _user.AddAsync(
            new User{
            UserName = addingUser.UserName,
            Email = addingUser.Email,
            Password = addingUser.Password
            });

        return Ok(
            new
            {
                message = "Пользователь добавлен."
            }
        );
    }
}
