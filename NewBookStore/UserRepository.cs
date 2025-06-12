namespace NewBookStore;

public class UserRepository : IUserRepository
{
    public List<OneUser> usersList = new List<OneUser>() {
        new OneUser(1001, "Пользователь 1", "mail1@domaine.com", "111"),
        new OneUser(1002, "Пользователь 2", "mail2@domaine.com", "222"),
        new OneUser(1003, "Пользователь 3", "mail3@domaine.com", "333")
    };


    public void Add(OneUser newItem)
    {
        bool isPresent = false;
        for (int i = 0; i < usersList.Count; i++)
        {
            if (newItem.Id == usersList[i].Id)
            {
                isPresent = true;
                break;
            }
        }
        if (isPresent == false) usersList.Add(newItem);
    }

    public void Delete(int id)
    {
        foreach (OneUser item in usersList)
        {
            if (item.Id == id)
            {
                usersList.Remove(item);
            }
        }
    }

    public OneUser[] GetAll()
    {
        var users = new OneUser[usersList.Count];

        for (int i = 0; i < usersList.Count; i++)
        {
            users[i] = usersList[i];
        }

        return users;
    }
}
public class OneUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Pussword { get; set; }
    public OneUser(int id, string name, string email, string pussword)
    {
        Id = id;
        Name = name;
        Email = email;
        Pussword = pussword;
    }
}
