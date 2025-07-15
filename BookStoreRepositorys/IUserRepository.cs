using BookStoreDb.Db;
namespace BookStoreRepositorys
{
    public interface IUserRepository
    {
        void Add(OneUser newItem);
        void Delete(int id);
        OneUser[] GetAll();

    }
}
