using _01_CarAnalysisQuery.Contracts.Blog;
using BlogManagment.Infrastracture.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_CarAnalysisQuery.Query
{
    public class BlogQuery : IBlogQuery
    {
        private readonly BlogContext _context;
        public BlogQuery(BlogContext context)
        {
            _context = context;
        }

        public BlogQueryModel GetBlogDetails(int id)
        {
            var blog = _context.Blogs.Select(x => new BlogQueryModel
            {
                Id = x.Id,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Title = x.Title,
                Writer = x.Writer,
                Description = x.Description,
                KeyWords = x.KeyWords,
                MetaDescription = x.MetaDescription,
                PublishDate = x.PublishDate,
                ShortDescription = x.ShortDescription,
                Slug = x.Slug,
            }).AsNoTracking().FirstOrDefault(x => x.Id == id);
            
            return blog;
        }
    }
}
