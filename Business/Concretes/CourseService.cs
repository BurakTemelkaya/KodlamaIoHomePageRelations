using Business.Abstracts;
using DataAccess.Abstracts;
using Entitities.Concretes;
using System.Linq.Expressions;

namespace Business.Concretes;

public class CourseService : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseService(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Delete(Course p)
    {
        _courseDal.Delete(p);
    }

    public Course? GetById(int id)
    {
        return _courseDal.Get(x => x.Id == id);
    }

    public void Insert(Course p)
    {
        _courseDal.Insert(p);
    }

    public List<Course?> List(Expression<Func<Course, bool>> filter = null)
    {
        return _courseDal.List(filter);
    }

    public void Update(Course p)
    {
        _courseDal.Update(p);
    }
}
