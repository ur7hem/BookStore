using BookStoreDb;
namespace BookStoreRepositorys
{
    public interface IGenreRepository
    {
        void Add(Genre newItem);
        void Delete(int id);
        Genre[] GetAll();

    }
}
