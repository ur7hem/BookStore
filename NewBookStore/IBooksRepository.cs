namespace NewBookStore
{
    public interface IBooksRepository
    {
        void Add(OneBooks newItem);
        void Delete(int id);
        OneBooks[] GetAll();
    }
}
