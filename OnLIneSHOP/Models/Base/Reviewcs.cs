namespace OnLIneSHOP.Models.Base
{
    public class Review : BaseClass
    {
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }

    }
}
