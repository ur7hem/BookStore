namespace BookStoreDb.Db
{
    public class Review
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public required string Text { get; set; }
        public int BookId { get; set; }
    }
}
