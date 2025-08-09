using BookStoreDb.Db;
namespace BookStoreRepositorys;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task DeleteAsync(int id);
    Task<User[]> GetAllAsync();
    Task<User?> GetByIdAsync(int id);

}
