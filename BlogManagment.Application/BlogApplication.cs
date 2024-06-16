using _0_Framework.Application;
using _0_Freamwork.Application;
using BlogManagment.Application.Contracts.Blog;
using BlogManagment.Domain.BlogAgg;

namespace BlogManagment.Application
{
    public class BlogApplication : IBlogApplication
    {
        private readonly IBlogRepository _blogRepository;

        public BlogApplication(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public OperationResult Create(CreateBlog command)
        {
            var operation = new OperationResult();
            if (_blogRepository.Exists(x => x.Title == command.Title))
            {
                return operation.Failed(ApplicationMessage.DuplicatedRecord);
            }

            var blog = new Blog(command.Title, command.ShortDescription, command.Description, command.Writer, command.Picture, command.PictureAlt, command.PictureTitle, command.Slug, command.KeyWords, command.MetaDescription);

            _blogRepository.Create(blog);
            _blogRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditBlog command)
        {
            var operation = new OperationResult();
            var blog = _blogRepository.Get(command.Id);
            if (blog == null)
            {
                operation.Failed(ApplicationMessage.RecordNotFound);
            }
            if (_blogRepository.Exists(x => x.Title == command.Title && x.Id != command.Id))
            {
                return operation.Failed(ApplicationMessage.DuplicatedRecord);
            }

            blog.Edit(command.Title, command.ShortDescription, command.Description, command.Writer, command.Picture, command.PictureAlt, command.PictureTitle, command.Slug, command.KeyWords, command.MetaDescription);

            _blogRepository.SaveChanges();
            return operation.Succedded();
        }

        public List<BlogViewModel> GetBlogs()
        {
            return _blogRepository.GetBlogs();
        }

        public EditBlog GetDetails(long id)
        {
            return _blogRepository.GetDetails(id);
        }

        public List<BlogViewModel> Search(BlogSearchModel searchModel)
        {
            return _blogRepository.Serach(searchModel);
        }
    }
}
