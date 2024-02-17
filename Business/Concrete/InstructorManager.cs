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
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _ınstructorDal;

        public InstructorManager(IInstructorDal ınstructorDal)
        {
            _ınstructorDal = ınstructorDal;
        }

        public void TAdd(Instructor entity)
        {
            _ınstructorDal.Add(entity);
        }

        public void TDelete(Instructor entity)
        {
            _ınstructorDal.Delete(entity);
        }

        public Instructor TGetById(int id)
        {
            return _ınstructorDal.GetById(id);
        }

        public List<Instructor> TGetListAll()
        {
            return _ınstructorDal.GetListAll();
        }

        public void TUpdate(Instructor entity)
        {
            _ınstructorDal.Update(entity);
        }
    }
}
