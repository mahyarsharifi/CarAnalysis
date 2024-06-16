using _0_Freamwork.Application;

namespace BlogManagment.Application.Contracts.Blog
{
    public interface IBlogApplication
    {
        OperationResult Create(CreateBlog command);
        OperationResult Edit(EditBlog command);
        EditBlog GetDetails(long id);
        List<BlogViewModel> GetBlogs();
        List<BlogViewModel> Search(BlogSearchModel searchModel);
    }
}