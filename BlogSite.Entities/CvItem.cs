namespace BlogSite.Entities
{
    public class CvItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Order { get; set; }
        public int UserId { get; set; }
    }
}
