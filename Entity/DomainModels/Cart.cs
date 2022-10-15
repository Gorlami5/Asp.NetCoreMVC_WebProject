using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DomainModels
{
    public class Cart:IDomainModel
    {
        public Cart()   //CartLines propunu direkt kullanamayacağımız için bu yapıyı kuruyoruz.
        {
            CartLines = new List<CartLine>();
        }
        public List<CartLine>  CartLines { get; set; }

    }
}
