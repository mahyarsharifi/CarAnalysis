namespace BlogManagment.Application.Contracts.Blog
{
    public class BlogViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string PublishDate { get; set; }
    }

}