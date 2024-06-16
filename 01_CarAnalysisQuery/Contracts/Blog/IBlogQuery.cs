namespace _01_CarAnalysisQuery.Contracts.Blog
{
    public interface IBlogQuery
    {
        BlogQueryModel GetBlogDetails(int id);
    }
}
