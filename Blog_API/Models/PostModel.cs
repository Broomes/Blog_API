namespace Blog_API.Models
{
    public class PostModel
    {
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Tags { get; set; }
        public string? Status { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
