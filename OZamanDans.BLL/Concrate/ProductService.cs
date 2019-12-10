using OZamanDans.BLL.Abstract;
using OZamanDans.DAL.Abstract;
using OZamanDans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.BLL.Concrate
{
    public class ProductService : IProductService
    {
        IProductDAL _dal;
        public ProductService(IProductDAL product)
        {
            _dal = product;
        }
        public void Delete(Product entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteByID(int id)
        {
            Product prod = _dal.Get(a => a.ProductID == id);
            _dal.Delete(prod);
        }

        public Product Get(int entityID)
        {
            return _dal.Get(a => a.ProductID == entityID);
        }

        public ICollection<Product> GetAll()
        {
            return _dal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryID)
        {
            return _dal.GetAll(a => a.CategoryID == categoryID).ToList();
        }

        public void Insert(Product entity)
        {
            _dal.Add(entity);
        }

        public void Update(Product entity)
        {
            _dal.Update(entity);
        }
    }
}
