using BookStoreDb.Db;
using BookStoreRepositorys;
using Microsoft.AspNetCore.Mvc;
using NewBookStore.Models;
using System.Diagnostics;


namespace NewBookStore.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IBooksRepository _booksRepository;
    private readonly IGenreRepository _genreRepository;

    public HomeController(IBooksRepository booksRepository, ILogger<HomeController> logger, IGenreRepository genreRepository)
    {
        _booksRepository = booksRepository;
        _logger = logger;
        _genreRepository = genreRepository;
    }

    public IActionResult Index()
    {

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public async Task<IActionResult> Books()
    {
        BookStoreDb.Db.Book[] allBooks = await _booksRepository.GetAllAsync();
        ViewBag.Knizka = allBooks;

        return View();
    }

    public async Task<IActionResult> OneBook(int bookId)
    {
        var oneBook = await _booksRepository.GetByIdAsync(bookId);
        ViewBag.oneBook = oneBook;

        //var oneAuthor = await _booksRepository.GetByIdAsync(oneBook.);
        //ViewBag.oneAuthor = oneAuthor;

        var oneGenre = await _genreRepository.GetByIdAsync(oneBook.GenreId);
        ViewBag.oneGenre = oneGenre;

        return View();
    }
    public IActionResult LogInForm()
    {
        return View();
    }
    public IActionResult Registration()
    {
        return View();
    }
    public async Task<IActionResult> AddForm()
    {
        BookStoreDb.Db.Genre[] allGenres = await _genreRepository.GetAllAsync();
        ViewBag.Genre = allGenres;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
