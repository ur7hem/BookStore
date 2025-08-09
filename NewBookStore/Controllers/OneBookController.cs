using BookStoreDb.Db;
using BookStoreRepositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewBookStore.Models;


namespace NewBookStore.Controllers;

public class OneBookController : Controller
{

    private readonly IBooksRepository _book;
    private readonly IGenreRepository _genre;
    public OneBookController(IBooksRepository book, IGenreRepository genre)
    {
        _book = book;
        _genre = genre;
    }


    [HttpPost]
    public async Task<IActionResult> OneBook([FromBody] OneBook bookId)
    {
        var oneBook = await _book.GetByIdAsync(bookId.BookId);
        ViewBag.oneBook = oneBook;


        return View();
    }
}
