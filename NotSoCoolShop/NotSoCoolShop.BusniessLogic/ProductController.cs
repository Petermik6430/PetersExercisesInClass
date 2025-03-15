using NotSoCoolShop.BusniessLogic.Interfaces;
using NotSoCoolShop.Domain;
using NotSoCoolShop.DataAccessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSoCoolShop.BusniessLogic
{
    public class ProductController : ICRUD<Product>
    {
        private DbProduct _dbProduct = new DbProduct();
        public void Create(Product entity)
        {
            //validate business logic
            _dbProduct.Create(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetAll()
        {
            return _dbProduct.GetAll();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
