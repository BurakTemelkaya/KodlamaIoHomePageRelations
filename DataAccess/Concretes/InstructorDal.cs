using DataAccess.Abstracts;
using Entitities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;

        public InstructorDal()
        {
            _instructors = new List<Instructor>()
            {
                new Instructor
                {
                    Id=1,
                    FirstName="Engin",
                    LastName="Demiroğ",
                    Email="Engin@kodlama.io",                  
                },
                new Instructor
                {
                    Id=2,
                    FirstName="Ahmet",
                    LastName="Demiroğ",
                    Email="Ahmet@kodlama.io",
                }
            };
        }
        public void Delete(Instructor p)
        {
            _instructors.Remove(p);
        }

        public Instructor? Get(Expression<Func<Instructor, bool>> filter)
        {
            return _instructors.AsQueryable().First(filter);
        }

        public void Insert(Instructor p)
        {
            _instructors.Add(p);
        }

        public List<Instructor?> List(Expression<Func<Instructor, bool>> filter = null)
        {
            var query = _instructors.AsQueryable();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return query.ToList();
        }

        public void Update(Instructor p)
        {
            var data = _instructors.First(c => c.Id == p.Id);
            if (data != null)
            {
                data = p;
            }
        }
    }
}
