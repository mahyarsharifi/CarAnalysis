using _0_Freamwork.Application;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Domain.CommentAgg;

namespace CommentManagement.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepository _commentRepository;

        public CommentApplication(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public OperationResult Add(AddComment command)
        {
            var operation = new OperationResult();
            var comment = new Comment(command.Name, command.Email, command.Message,
                command.Type, command.ParentId);

            _commentRepository.Create(comment);
            _commentRepository.SaveChanges();
            return operation.Succedded();
        }
        public List<CommentViewModel> GetBlogCommentsByParentId(int parentId)
        {
            return _commentRepository.GetBlogCommentsByParentId(parentId);
        }
        public List<CommentViewModel> GetCarCommentsByParentId(int parentId)
        {
            return _commentRepository.GetCarCommentsByParentId(parentId);
        }

        public List<CommentViewModel> GetComments()
        {
            return _commentRepository.GetComments();
        }
    }
}
