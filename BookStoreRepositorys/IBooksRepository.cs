using BookStoreDb.Db;


namespace BookStoreRepositorys;

public interface IBooksRepository
{
    Task AddAsync(Book book);
    Task DeleteAsync(int id);
    Task<Book[]> GetAllAsync();
    Task<Book?> GetByIdAsync(int id);
}
