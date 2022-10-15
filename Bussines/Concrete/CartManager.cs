using Bussines.Abstract;
using Entity.Concrete;
using Entity.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            
            
            CartLine cartLine = cart.CartLines.FirstOrDefault(c=> c.Product.ProductId == product.ProductId);
            if(cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }

            cart.CartLines.Add(new CartLine { Product = product,Quantity = 1});
        }

        public List<CartLine> GetList(Cart cart) //CartLine tipinde olmasının sebebi o tipe göre elemanlar ekleneceği veya listeleneceği için
        {
            return cart.CartLines;
        }

        public void RemoveToCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));
        }
    }
}
