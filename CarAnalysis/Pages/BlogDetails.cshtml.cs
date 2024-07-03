using _01_CarAnalysisQuery.Contracts.Blog;
using CommentManagement.Application.Contracts.Comment;
using CommnetManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Pages
{
    public class BlogDetailsModel : PageModel
    {
        public BlogQueryModel Blog;
        public List<CommentViewModel> Comments;

        private readonly IBlogQuery _blogQuery;
        private readonly ICommentApplication _commentApplication;

        public BlogDetailsModel(IBlogQuery blogQuery, ICommentApplication commentApplication)
        {
            _blogQuery = blogQuery;
            _commentApplication = commentApplication;
        }

        public void OnGet(int id)
        {
            Blog = _blogQuery.GetBlogDetails(id);
            Comments = _commentApplication.GetBlogCommentsByParentId(id);
        }
        public IActionResult OnPost(AddComment command, int id)
        {
            command.Type = CommentType.Blog;
            command.ParentId = id;
            var result = _commentApplication.Add(command);
            return RedirectToPage("./BlogDetails", new { Id = id });
        }
    }
}
