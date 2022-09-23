using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetById(int id);
    }
}
