using DataAccess.Abstracts;
using Entitities.Concretes;
using System.Linq.Expressions;

namespace DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public CategoryDal()
        {
            _categories =
            [
                new Category
                {
                    Id = 1,
                    Name = "C#"
                },
                new Category
                {
                    Id = 2,
                    Name = "Java"
                },
                new Category
                {
                    Id = 3,
                    Name = "JS"
                },
            ];
        }


        public void Delete(Category p)
        {
            _categories.Remove(p);
        }

        public Category? Get(Expression<Func<Category, bool>> filter = null)
        {
            return _categories.AsQueryable().First(filter);
        }

        public void Insert(Category p)
        {
            _categories.Add(p);
        }

        public List<Category?> List(Expression<Func<Category, bool>> filter = null)
        {
            var query = _categories.AsQueryable();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return query.ToList();
        }

        public void Update(Category p)
        {
            var data = _categories.First(c => c.Id == p.Id);
            if (data != null)
            {
                data = p;
            }
        }
    }
}
