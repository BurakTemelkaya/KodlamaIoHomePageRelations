using System.Linq.Expressions;

namespace DataAccess.Abstracts
{
    public interface IRepository<T>
    {
        void Insert(T p);
        T? Get(Expression<Func<T, bool>> filter = null);
        void Delete(T p);
        void Update(T p);
        List<T?> List(Expression<Func<T, bool>> filter = null);
    }
}
