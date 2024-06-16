using _0_Freamwork.Application;
using System.Collections.Generic;

namespace CommentManagement.Application.Contracts.Comment
{
    public interface ICommentApplication
    {
        OperationResult Add(AddComment command);
        List<CommentViewModel> GetComments();
        List<CommentViewModel> GetCarCommentsByParentId(int parentId);
        List<CommentViewModel> GetBlogCommentsByParentId(int parentId);
    }
}
