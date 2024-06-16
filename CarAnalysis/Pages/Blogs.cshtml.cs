using BlogManagment.Application.Contracts.Blog;
using BlogManagment.Domain.BlogAgg;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Pages
{
    public class BlogsModel : PageModel
    {
        public List<BlogViewModel> Blog;
        private readonly IBlogRepository _blogRepository;

        public BlogsModel(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public void OnGet()
        {
            Blog = _blogRepository.GetBlogs();
        }
    }
}
