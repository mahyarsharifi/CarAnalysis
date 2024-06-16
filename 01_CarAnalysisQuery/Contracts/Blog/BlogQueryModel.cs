using _01_LampshadeQuery.Contracts.Comment;

namespace _01_CarAnalysisQuery.Contracts.Blog
{
    public class BlogQueryModel 
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Writer { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public DateTime PublishDate { get; set; }
        public string Slug { get; set; }
        public string KeyWords { get; set; }
        public string MetaDescription { get; set; }
        public List<CommentQueryModel> Comments { get; set; }
    }
}
