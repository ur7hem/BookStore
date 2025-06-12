namespace NewBookStore
{
    public class GenreRepository : IGenreRepository
    {
        public List<Genre> genresList = new List<Genre>() {
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
            bool isPresent = false;
            for (int i = 0; i < genresList.Count; i++)
            {
                if (newItem.Id == genresList[i].Id)
                {
                    isPresent = true;
                    break;
                }
            }
            if (isPresent == false) genresList.Add(newItem);
        }

        public void Delete(int id)
        {
            foreach (Genre item in genresList)
            {
                if (item.Id == id)
                {
                    genresList.Remove(item);
                }
            }
        }

        public Genre[] GetAll()
        {
            var genres = new Genre[genresList.Count];

            for (int i = 0; i < genresList.Count; i++)
            {
                genres[i] = genresList[i];
            }
            //        ViewBag.Knizka = books;

            return genres;
        }
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
}
