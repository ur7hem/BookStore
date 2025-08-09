using BookStoreDb.Db;
namespace BookStoreRepositorys;

public class GenreRepository : BaseRepository<Genre>,  IGenreRepository
{
    private readonly BookDbContext _context;
    public GenreRepository(BookDbContext context) : base(context)
    {
//        _context = context;
    }
}