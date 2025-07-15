using BookStoreRepositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewBookStore.Models;


namespace NewBookStore.Controllers;

public class AddBookController : Controller
{

    private readonly IBooksRepository _book;
    public AddBookController(IBooksRepository book)
    {
        _book = book;
    }


    [HttpPost]
    public async Task<IActionResult> addBook([FromBody] AddBook addingBook)
    {
        await _book.AddAsync(
            addingBook.Name,
            addingBook.Description,
            addingBook.PublishingHouse
            );

        return Ok();
    }
}
