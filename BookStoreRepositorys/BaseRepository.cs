using BookStoreDb.Db;
using Microsoft.EntityFrameworkCore;

namespace BookStoreRepositorys;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity<int>
{
    private readonly BookDbContext _context;

    public BaseRepository(BookDbContext context)
    {
        _context = context;
    }


    public async Task AddAsync(T entity)
    {
        await _context.Set<T >().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity != null)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        
    }

    public async Task<T[]> GetAllAsync()
    {
        var items = await _context.Set<T>().ToListAsync();
        return items.ToArray();
        
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
}