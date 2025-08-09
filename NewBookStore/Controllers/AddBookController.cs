using BookStoreDb.Db;
using BookStoreRepositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewBookStore.Models;


namespace NewBookStore.Controllers;

public class AddBookController : Controller
{

    private readonly IBooksRepository _book;
    private readonly IGenreRepository _genre;
    public AddBookController(IBooksRepository book, IGenreRepository genre)
    {
        _book = book;
        _genre = genre;
    }


    [HttpPost]
    public async Task<IActionResult> addBook([FromBody] AddBook addingBook)
    {
        await _book.AddAsync(
            new Book{
            Name = addingBook.Name,
            Description = addingBook.Description,
            PublishingHouse = addingBook.PublishingHouse,
            GenreId = addingBook.GenreId,
            YearOfPublication = addingBook.YearOfPublication
            });

        return Ok(
            new
            {
                message = "Книга добавлена."
            }
        );
    }
}
