using BookStoreDb.Db;
namespace BookStoreRepositorys;

public class GenreRepository : IGenreRepository
{
    private readonly List<Genre> _genresList = new() {
        new Genre(2001, "Любовный роман"),
        new Genre(2002, "Фэнтези"),
        new Genre(2003, "Научная фантастика"),
        new Genre(2004, "Детектив"),
        new Genre(2005, "Ужасы"),
        new Genre(2006, "Триллер"),
        new Genre(2007, "Приключенческий боевик"),
        new Genre(2008, "Историческая фантастика"),
        new Genre(2009, "Художественная литература")
    };


    public void Add(Genre newItem)
    {
        bool isPresent = _genresList.Any(t => newItem.Id == t.Id);
        if (!isPresent) _genresList.Add(newItem);
    }

    public void Delete(int id)
    {
        foreach (var item in _genresList)
        {
            if (item.Id == id)
            {
                _genresList.Remove(item);
            }
        }
    }

    public Genre[] GetAll()
        => _genresList.ToArray();
}


public class Genre
{
    public int Id { get; set; }
    public string GenreName { get; set; }
    public Genre(int id, string genreName)
    {
        Id = id;
        GenreName = genreName;
    }
}