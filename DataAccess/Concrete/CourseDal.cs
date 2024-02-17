using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        private readonly List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>()
            {
                new Course { CourseId = 1, CourseName = "C# + Angular", Description = "Yazılım Geliştirici Yetiştirici Kampı (C# + Angular)",CategoryId=1, InstructorId=1},
                new Course { CourseId = 2, CourseName = "Javascript", Description = "Yazılım Geliştirici Yetiştirici Kampı (Javascript)", CategoryId=1, InstructorId=1},
                new Course { CourseId = 3, CourseName = "Java + React", Description = "Yazılım Geliştirici Yetiştirici Kampı (Java + React)", CategoryId=1, InstructorId=1},
                new Course { CourseId = 4, CourseName = ".Net", Description = "Senior Yazılım Geliştirici Kampı (.Net)", CategoryId=1, InstructorId=1}
            };
        }
        public void Add(Course entity)
        {
            _courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            var result = _courses.FirstOrDefault(c => c.CourseId == entity.CourseId);
            if (result != null)
            {
                _courses.Remove(result);
            }
        }

        public Course GetById(int id)
        {
            var result = _courses.FirstOrDefault(c => c.CourseId == id);
            return result;
        }

        public List<Course> GetListAll()
        {
            return _courses.ToList();
        }

        public void Update(Course entity)
        {
            var result = _courses.FirstOrDefault(c => c.CourseId == entity.CourseId);
            if (result != null)
            {
                result.CourseName = entity.CourseName;
                result.Description = entity.Description;
                result.CategoryId = entity.CategoryId;
                result.InstructorId = entity.InstructorId;
            }
        }
    }
}
