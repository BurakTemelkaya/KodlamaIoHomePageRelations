using Business.Abstracts;
using DataAccess.Abstracts;
using Entitities.Concretes;
using System.Linq.Expressions;

namespace Business.Concretes
{
    public class InstructorService : IInstructorService
    {

        private readonly IInstructorDal _instructorDal;

        public InstructorService(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Delete(Instructor p)
        {
            _instructorDal.Delete(p);
        }

        public Instructor? GetById(int id)
        {
            return _instructorDal.Get(x => x.Id == id);
        }

        public void Insert(Instructor p)
        {
            _instructorDal.Insert(p);
        }

        public List<Instructor?> List(Expression<Func<Instructor, bool>> filter = null)
        {
            return _instructorDal.List(filter);
        }

        public void Update(Instructor p)
        {
            _instructorDal.Update(p);
        }
    }
}
