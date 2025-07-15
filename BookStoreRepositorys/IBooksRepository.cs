using BookStoreDb.Db;


namespace BookStoreRepositorys;

public interface IBooksRepository
{
    Task AddAsync(string name, string description, string publishingHouse);
    void Delete(int id);
    Task<Book[]> GetAllAsync();
}
