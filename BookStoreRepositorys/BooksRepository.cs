using Microsoft.EntityFrameworkCore;
using BookStoreDb.Db;

namespace BookStoreRepositorys;

public class BooksRepository : IBooksRepository
{
    private readonly BookDbContext _context;

    public BooksRepository(BookDbContext context)
    {
        _context = context;
    }


    public async Task AddAsync(string name, string description, string publishingHouse)
    {
        await _context.Books.AddAsync(
            new Book
            {
                Name = name,
                Description = description,
                PublishingHouse = publishingHouse
            });

        await _context.SaveChangesAsync();
    }

    public void Delete(int id)
    {/*
        foreach (Book item in books)
        {
            if (item.Id == id)
            {
                books.Remove(item);
            }
        }*/
    }

    public async Task<Book[]> GetAllAsync()
    {

//        await _context.Books.AddAsync(
//        new Book
//        {
//            Name = "Test",
//            Description = "sdfsadf",
//            PublishingHouse = "fsdfsd"
//        });

//        await _context.SaveChangesAsync();
        

        var books = await _context.Books
            .ToListAsync();

        return books.ToArray();  
    }
}

public class BookService(BookDbContext context)
{
    public Task<List<Book>> GetBooksAsync()
        => context.Books.ToListAsync();
}
  
 


//public class OneBooks
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Description { get; set; }
//    public string PublishingHouse { get; set; }
//    public int YearOfPublication { get; set; }
//    public OneBooks(int id, string name, string description, string publishingHouse, int yearOfPublication)
//    {
//        Id = id;
//        Name = name;
//        Description = description;
//        PublishingHouse = publishingHouse;
//        YearOfPublication = yearOfPublication;
//    }
//}
