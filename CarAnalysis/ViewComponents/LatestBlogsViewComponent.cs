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
            Blog.Take(5);
            return View(Blog);
        }
    }
}
