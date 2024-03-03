namespace ELECT2_QUIZ1.Models
{
    public class BlogsModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string MainImage { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Writer { get; set; } = string.Empty;
        public int Year { get; set; }
        public int Month { get; set; }
        public string Slug { get; set; } = string.Empty;
    }
}
