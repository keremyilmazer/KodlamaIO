
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace KodlamaIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager(new CourseDal());
            foreach (var course in courseManager.TGetListAll())
            {
                Console.WriteLine(course.CourseName);
            }
        }
    }
}
