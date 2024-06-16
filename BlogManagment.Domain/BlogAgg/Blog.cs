namespace BlogManagment.Domain.BlogAgg
{
    public class Blog
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

        public Blog(string title, string shortDescription, string description, string writer, string picture,
            string pictureAlt, string pictureTitle, string slug, string keyWords, string metaDescription)
        {
            Title = title;
            ShortDescription = shortDescription;
            Description = description;
            Writer = writer;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            PublishDate = DateTime.Now;
            Slug = slug;
            KeyWords = keyWords;
            MetaDescription = metaDescription;
        }
        public void Edit(string title, string shortDescription, string description, string writer, string picture,
            string pictureAlt, string pictureTitle, string slug, string keyWords, string metaDescription)
        {
            Title = title;
            ShortDescription = shortDescription;
            Description = description;
            Writer = writer;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            KeyWords = keyWords;
            MetaDescription = metaDescription;
        }
    }
}
