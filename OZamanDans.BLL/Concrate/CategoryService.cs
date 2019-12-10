using OZamanDans.BLL.Abstract;
using OZamanDans.DAL.Abstract;
using OZamanDans.DAL.Concrate.EntityFramework.DAL;
using OZamanDans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.BLL.Concrate
{
    public class CategoryService : ICategoryService
    {
        ICategoryDAL _dal;
        public CategoryService(ICategoryDAL category)
        {
            _dal = category;
        }
        public void Delete(Category entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteByID(int id)
        {
            Category cat = _dal.Get(a => a.CategoryID == id);
            _dal.Delete(cat);
        }

        public Category Get(int entityID)
        {
            return _dal.Get(a => a.CategoryID == entityID);
        }

        public ICollection<Category> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Category entity)
        {
            _dal.Add(entity);
        }

        public void Update(Category entity)
        {
            _dal.Update(entity);
        }
    }
}
