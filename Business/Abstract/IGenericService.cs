using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenericService<T> 
    {
        List<T> TGetListAll();
        T TGetById(int id);
        void TAdd(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
    }
}
