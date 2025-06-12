namespace NewBookStore;

public class BooksRepository : IBooksRepository
{
    public List<OneBooks> booksList = new List<OneBooks>() {
        new OneBooks(1001, "Книга 1", "Описание 1", "Издательство 1", 1995),
        new OneBooks(1002, "Книга 2", "Описание 2", "Издательство 2", 1997),
        new OneBooks(1003, "Книга 3", "Описание 3", "Издательство 3", 2005),
        new OneBooks(1004, "Книга 4", "Описание 4", "Издательство 4", 2008),
        new OneBooks(1005, "Книга 5", "Описание 5", "Издательство 5", 2012),
        new OneBooks(1006, "Книга 6", "Описание 6", "Издательство 6", 1998),
        new OneBooks(1007, "Книга 7", "Описание 7", "Издательство 7", 2021),
        new OneBooks(1008, "Книга 8", "Описание 8", "Издательство 8", 2020)
    };


    public void Add(OneBooks newItem)
    {
        bool isPresent = false;
        for (int i = 0; i < booksList.Count; i++)
        {
            if (newItem.Id == booksList[i].Id)
            {
                isPresent = true;
                break;
            }
        }
        if (isPresent == false) booksList.Add(newItem);
    }

    public void Delete(int id)
    {
        foreach (OneBooks item in booksList)
        {
            if (item.Id == id)
            {
                booksList.Remove(item);
            }
        }
    }

    public OneBooks[] GetAll()
    {
        var books = new OneBooks[booksList.Count];

        for (int i = 0; i < booksList.Count; i++)
        {
            books[i] = booksList[i];
        }
//        ViewBag.Knizka = books;

        return books;
    }
}


public class OneBooks
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string PublishingHouse { get; set; }
    public int YearOfPublication { get; set; }
    public OneBooks(int id, string name, string description, string publishingHouse, int yearOfPublication)
    {
        Id = id;
        Name = name;
        Description = description;
        PublishingHouse = publishingHouse;
        YearOfPublication = yearOfPublication;
    }
}
