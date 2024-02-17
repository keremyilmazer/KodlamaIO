using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private readonly  List<Category> _category;
        public CategoryDal()
        {
            _category = new List<Category>
            {
                new Category{CategoryId=1, CategoryName = "Frontend"},
                new Category{CategoryId=2, CategoryName="Backend"},
                new Category{CategoryId=3, CategoryName="Siber Güvenlik"}
            };
        }
        public void Add(Category entity)
        {
            _category.Add(entity);
        }

        public void Delete(Category entity)
        {
            var result = _category.FirstOrDefault(c => c.CategoryId == entity.CategoryId);
            if (result != null)
            {
                _category.Remove(result);
            }
        }

        public Category GetById(int id)
        {
            var result = _category.FirstOrDefault(c => c.CategoryId == id);
            return result;
        }

        public List<Category> GetListAll()
        {
            return _category.ToList();
        }

        public void Update(Category entity)
        {
            var result = _category.FirstOrDefault(c => c.CategoryId == entity.CategoryId);
            if (result != null)
            {
                result.CategoryName = entity.CategoryName;
            }
        }
    }
}
