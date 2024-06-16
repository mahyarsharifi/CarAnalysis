using _0_Freamwork.Infrastrucure;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Domain.CommentAgg;
using System.Security.Cryptography.X509Certificates;

namespace CommnetManagement.Infrastructure.EFCore.Repository
{
    public class CommentRepository : RepositoryBase<long, Comment>, ICommentRepository
    {
        private readonly CommentContext _context;

        public CommentRepository(CommentContext context) : base(context)
        {
            _context = context;
        }

        public List<CommentViewModel> GetBlogCommentsByParentId(int parentId)
        {
            return _context.Comments.Where(x => x.Type == 2 && x.ParentId == parentId).Select(x => new CommentViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Type = x.Type,
                Email = x.Email,
                Message = x.Message
            }).ToList();
        }
        public List<CommentViewModel> GetCarCommentsByParentId(int parentId)
        {
            return _context.Comments.Where(x => x.Type == 1 && x.ParentId == parentId).Select(x => new CommentViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Type = x.Type,
                Email = x.Email,
                Message = x.Message
            }).ToList();
        }

        public List<CommentViewModel> GetComments()
        {
            return _context.Comments.Select(x => new CommentViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Type = x.Type,
                Email = x.Email,
                Message = x.Message
            }).ToList();
        }
    }
}
