using _0_Framework.Application;
using _0_Freamwork.Infrastrucure;
using BlogManagment.Application.Contracts.Blog;
using BlogManagment.Domain.BlogAgg;
using System.Security.Cryptography.X509Certificates;

namespace BlogManagment.Infrastracture.EFCore.Repository
{
    public class BlogRepository : RepositoryBase<long, Blog>, IBlogRepository
    {
        private readonly BlogContext _context;

        public BlogRepository(BlogContext context) : base(context)
        {
            _context = context;
        }

        public Blog Get(long id)
        {
            return _context.Blogs.Find(id);
        }

        public List<BlogViewModel> GetBlogs()
        {
            return _context.Blogs.Select(x => new BlogViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                Description = x.Description
            }).ToList();
        }

        public EditBlog GetDetails(long id)
        {
            return _context.Blogs.Select(x => new EditBlog
            {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                Description = x.Description,
                MetaDescription = x.MetaDescription,
                KeyWords = x.KeyWords,
                ShortDescription = x.ShortDescription,
                Writer = x.Writer,
                Slug = x.Slug,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<BlogViewModel> Serach(BlogSearchModel searchModel)
        {
            var query = _context.Blogs.Select(x => new BlogViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                Description = x.Description,
                PublishDate = x.PublishDate.ToFarsi()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Title))
                query = query.Where(x => x.Title.Contains(searchModel.Title));

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
