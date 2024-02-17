using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void TAdd(Course entity)
        {
            _courseDal.Add(entity);
        }

        public void TDelete(Course entity)
        {
            _courseDal.Delete(entity);
        }

        public Course TGetById(int id)
        {
           return _courseDal.GetById(id);
        }

        public List<Course> TGetListAll()
        {
            return _courseDal.GetListAll();
        }

        public void TUpdate(Course entity)
        {
            _courseDal.Update(entity);
        }
    }
}
