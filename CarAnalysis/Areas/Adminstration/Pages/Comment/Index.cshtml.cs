using CommentManagement.Application.Contracts.Comment;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Areas.Adminstration.Pages.Comment
{
    public class IndexModel : PageModel
    {
        public List<CommentViewModel> Comments;
        private readonly ICommentApplication _commentApplication;

        public IndexModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }

        public void OnGet()
        {
            Comments = _commentApplication.GetComments();
        }
    }
}
