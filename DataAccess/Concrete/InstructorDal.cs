using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        private readonly List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>()
            {
                new Instructor{InstructorId=1, FirstName="Engin", LastName="Demiroğ"},
                new Instructor{InstructorId=2, FirstName="Halit Enes", LastName="Kalaycı"}
            };
        }

        public void Add(Instructor entity)
        {
            _instructors.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            var result = _instructors.FirstOrDefault(c => c.InstructorId == entity.InstructorId);
            if (result != null)
            {
                _instructors.Remove(result);
            }
        }

        public Instructor GetById(int id)
        {
            var result = _instructors.FirstOrDefault(c => c.InstructorId == id);
            return result;
        }

        public List<Instructor> GetListAll()
        {
            return _instructors.ToList();
        }

        public void Update(Instructor entity)
        {
            var result = _instructors.FirstOrDefault(c => c.InstructorId == entity.InstructorId);
            if (result != null)
            {
                result.FirstName = entity.FirstName;
                result.LastName = entity.LastName;
            }
        }
    }
}
