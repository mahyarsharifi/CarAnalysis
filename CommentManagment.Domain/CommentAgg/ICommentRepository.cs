using _0_Freamwork.Domain;
using CommentManagement.Application.Contracts.Comment;

namespace CommentManagement.Domain.CommentAgg
{
    public interface ICommentRepository : IRepository<long, Comment>
    {
        List<CommentViewModel> GetComments();
        List<CommentViewModel> GetCarCommentsByParentId(int parentId);
        List<CommentViewModel> GetBlogCommentsByParentId(int parentId);

    }
}
