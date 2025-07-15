namespace BookStoreDb.Db
{
    public class OrderHistory
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
    }
}
