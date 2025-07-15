using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewBookStore.Models;
using BookStoreRepositorys;


namespace NewBookStore.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IBooksRepository _booksRepository;

    public HomeController(IBooksRepository booksRepository, ILogger<HomeController> logger)
    {
        _booksRepository = booksRepository;
        _logger = logger;
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
        var allBooks = await _booksRepository.GetAllAsync();
        ViewBag.Knizka = allBooks;

        return View();
    }

    public IActionResult OneBook()
    {
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
    public IActionResult AddForm()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
