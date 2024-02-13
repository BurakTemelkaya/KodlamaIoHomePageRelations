using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IGenericService<T>
    {
        void Insert(T p);
        T? GetById(int id);
        void Delete(T p);
        void Update(T p);
        List<T?> List(Expression<Func<T, bool>> filter = null);
    }
}
