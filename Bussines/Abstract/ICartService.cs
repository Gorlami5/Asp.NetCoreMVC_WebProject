using Entity.Concrete;
using Entity.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart,Product product);
        void RemoveToCart(Cart cart,int productId);
        List<CartLine> GetList(Cart cart);
    }
}
