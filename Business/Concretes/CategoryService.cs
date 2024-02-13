using Business.Abstracts;
using DataAccess.Abstracts;
using Entitities.Concretes;
using System.Linq.Expressions;

namespace Business.Concretes;

public class CategoryService : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryService(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Delete(Category p)
    {
        _categoryDal.Delete(p);
    }

    public Category? GetById(int id)
    {
        return _categoryDal.Get(x => x.Id == id);
    }

    public void Insert(Category p)
    {
        _categoryDal.Insert(p);
    }

    public List<Category?> List(Expression<Func<Category, bool>> filter = null)
    {
        return _categoryDal.List(filter);
    }

    public void Update(Category p)
    {
        _categoryDal.Update(p);
    }
}
