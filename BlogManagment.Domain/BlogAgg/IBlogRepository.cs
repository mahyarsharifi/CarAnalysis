using _0_Freamwork.Domain;
using BlogManagment.Application.Contracts.Blog;

namespace BlogManagment.Domain.BlogAgg
{
    public interface IBlogRepository : IRepository<long, Blog>
    {
        Blog Get(long id);
        List<BlogViewModel> GetBlogs();
        EditBlog GetDetails(long id);
        List<BlogViewModel> Serach(BlogSearchModel searchModel);
    }
}
