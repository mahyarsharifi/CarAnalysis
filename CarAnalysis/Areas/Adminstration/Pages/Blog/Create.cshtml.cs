using BlogManagment.Application.Contracts.Blog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Areas.Adminstration.Pages.Blog
{
    public class CreateModel : PageModel
    {
        public CreateBlog Command;

        private readonly IBlogApplication _blogApplication;
        public CreateModel(IBlogApplication blogApplication)
        {
            _blogApplication = blogApplication;
        }

        public void OnGet()
        {
        }
        public JsonResult OnPost(CreateBlog command)
        {
            var result = _blogApplication.Create(command);
            return new JsonResult(result);
        }
    }
}
