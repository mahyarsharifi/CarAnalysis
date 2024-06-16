using BlogManagment.Application.Contracts.Blog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Areas.Adminstration.Pages.Blog
{
    public class EditModel : PageModel
    {
        public EditBlog Command;

        private readonly IBlogApplication _blogApplication;
        public EditModel(IBlogApplication blogApplication)
        {
            _blogApplication = blogApplication;
        }

        public void OnGet(long id)
        {
            Command = _blogApplication.GetDetails(id);
        }
        public JsonResult OnPost(EditBlog command)
        {
            var result = _blogApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
