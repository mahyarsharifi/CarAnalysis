using _0_Freamwork.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace _0_Freamwork.Infrastrucure
{
    public class RepositoryBase<TKey, T> : IRepository<TKey, T> where T : class
    {
        private readonly DbContext _context;
        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add(entity);
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
