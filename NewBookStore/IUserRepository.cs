namespace NewBookStore
{
    public interface IUserRepository
    {
        void Add(OneUser newItem);
        void Delete(int id);
        OneUser[] GetAll();

    }
}
