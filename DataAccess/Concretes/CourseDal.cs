using DataAccess.Abstracts;
using Entitities.Concretes;
using System.Linq.Expressions;

namespace DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> _courses;
    public CourseDal()
    {
        _courses = new List<Course>()
        {
            new Course()
            {
                Id = 1,
                CategoryId = 1,
                InstructorId = 1,
                Name="2024 Yazılım Geliştirici Yetiştirme Kampı (C#)"
            },
            new Course()
            {
                Id = 2,
                CategoryId = 1,
                InstructorId = 1,
                Name="Senior Geliştirici Yetiştirme Kampı (C#)"
            },
        };
    }
    public void Delete(Course p)
    {
        _courses.Remove(p);
    }

    public Course? Get(Expression<Func<Course, bool>> filter)
    {
        return _courses.AsQueryable().First(filter);
    }

    public void Insert(Course p)
    {
        _courses.Add(p);
    }

    public List<Course?> List(Expression<Func<Course, bool>> filter = null)
    {
        var query = _courses.AsQueryable();
        if (filter != null)
        {
            query = query.Where(filter);
        }
        return query.ToList();
    }

    public void Update(Course p)
    {
        var data = _courses.First(c => c.Id == p.Id);
        if (data != null)
        {
            data = p;
        }
    }
}
