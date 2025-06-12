using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewBookStore.Models;

namespace NewBookStore.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IBooksRepository _books;

    public HomeController(IBooksRepository books)
    {
        _books = books;
    }

/*    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }*/

    public IActionResult Index()
    {

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Books()
    {
        var allBooks = _books.GetAll();
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

/*    public IActionResult login()
    {
        return View();
    }*/


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

/*    public class AllBooks
    {
        public string Name { get; set; }
        public string Comments { get; set; }
        public AllBooks(string name, string comments)
        {
            Name = name;
            Comments = comments;
        }
    }*/





}
