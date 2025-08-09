namespace BookStoreDb.Db
{
    public class Genre : IEntity<int>
    {
        public int Id { get; set; }
        public required string GenreName { get; set; }
    }
}
