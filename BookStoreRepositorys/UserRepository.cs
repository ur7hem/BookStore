using BookStoreDb.Db;
namespace BookStoreRepositorys;

public class UserRepository : IUserRepository
{
    private readonly List<OneUser> _usersList =
    [
        new OneUser(1001, "Пользователь 1", "mail1@domaine.com", "111"),
        new OneUser(1002, "Пользователь 2", "mail2@domaine.com", "222"),
        new OneUser(1003, "Пользователь 3", "mail3@domaine.com", "333")
    ];


    public void Add(OneUser newItem)
    {
        bool isPresent = _usersList.Any(t => newItem.Id == t.Id);
        if (isPresent == false) _usersList.Add(newItem);
    }

    public void Delete(int id)
    {
        foreach (var item in _usersList)
        {
            if (item.Id == id)
            {
                _usersList.Remove(item);
            }
        }
    }

    public OneUser[] GetAll()
    {
        var users = new OneUser[_usersList.Count];

        for (int i = 0; i < _usersList.Count; i++)
        {
            users[i] = _usersList[i];
        }

        return users;
    }
}
public class OneUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public OneUser(int id, string name, string email, string password)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
    }
}
