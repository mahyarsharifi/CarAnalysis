using BlogManagment.Application.Contracts.Blog;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Areas.Adminstration.Pages.Blog
{
    public class IndexModel : PageModel
    {
        public List<BlogViewModel> Blogs;
        public BlogSearchModel SearchModel;

        private readonly IBlogApplication _blogApplication;

        public IndexModel(IBlogApplication blogApplication)
        {
            _blogApplication = blogApplication;
        }

        public void OnGet(BlogSearchModel searchModel)
        {
            Blogs = _blogApplication.Search(searchModel);
        }
    }
}
