using System.Linq.Expressions;

namespace _0_Freamwork.Domain
{
    public interface IRepository<TKey, T> where T : class
    {
        void Create(T entity);
        bool Exists(Expression<Func<T, bool>> expression);
        void SaveChanges();
    }
}
