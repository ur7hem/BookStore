using BookStoreDb.Db;
namespace BookStoreRepositorys;

public interface IGenreRepository
{
    Task AddAsync(Genre genre);
    Task DeleteAsync(int id);
    Task<Genre[]> GetAllAsync();
    Task<Genre?> GetByIdAsync(int id);

}
