using Microsoft.EntityFrameworkCore;
using BookStoreDb.Db;

namespace BookStoreRepositorys;

public class BooksRepository : BaseRepository<Book>, IBooksRepository
{
    private readonly BookDbContext _context;

    public BooksRepository(BookDbContext context) : base(context)
    {
//        _context = context;
    }


}