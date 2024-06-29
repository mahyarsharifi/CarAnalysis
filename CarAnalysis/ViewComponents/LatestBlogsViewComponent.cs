using BlogManagment.Application.Contracts.Blog;
using BlogManagment.Domain.BlogAgg;
using Microsoft.AspNetCore.Mvc;

namespace CarAnalysis.ViewComponents
{
    public class LatestBlogsViewComponent : ViewComponent
    {
        public List<BlogViewModel> Blog;
        private readonly IBlogRepository _blogRepository;

        public LatestBlogsViewComponent(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public IViewComponentResult Invoke()
        {
            Blog = _blogRepository.GetBlogs();
            var latestBlogs = Blog.OrderByDescending(b => b.Id).Take(3).ToList();
            return View(latestBlogs);
        }
    }
}
