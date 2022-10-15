using Bussines.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class ProductManager : IProductService
    {

       protected IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetById(int id)
        {
           var a =  _productDal.GetList(p => p.CategoryId == id);
           return a;
        }

        public Product GetById2(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }


        // List olarak döndersek ne olur sonucuna bak
       



    }
}
