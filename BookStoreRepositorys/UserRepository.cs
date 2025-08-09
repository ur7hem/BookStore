using Microsoft.EntityFrameworkCore;
using BookStoreDb.Db;
namespace BookStoreRepositorys;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    private readonly BookDbContext _context;
    public UserRepository(BookDbContext context) : base(context)
    {
//        _context = context;
    }

}
