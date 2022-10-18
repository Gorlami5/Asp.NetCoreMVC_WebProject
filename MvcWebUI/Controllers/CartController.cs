using Bussines.Abstract;
using Entity.Concrete;
using Entity.DomainModels;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Helpers;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class CartController:Controller
    {
        private ICartService _cartService;
        private ICartSessionHelper _cartSessionHelper;
        private IProductService _productService;

        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            Product product = _productService.GetById2(productId);
          
           
            var cart = _cartSessionHelper.GetCart("cart");

            _cartService.AddToCart(cart, product);

            _cartSessionHelper.SetCart("cart", cart);

            TempData.Add("message", product.ProductName + "added to cart");

            return RedirectToAction("Index", "Product");
        }

        public IActionResult Index()
        {
            var model = new CartListViewModel()
            {
                Cart = _cartSessionHelper.GetCart("cart")
            };
            return View(model);
        }


        public IActionResult RemoveToCart(int productId)
        {
            Product product = _productService.GetById2(productId);

            var cart = _cartSessionHelper.GetCart("cart");

            _cartService.RemoveToCart(cart, productId);

            _cartSessionHelper.SetCart("cart", cart);

            TempData.Add("message", product.ProductName + "removed from Cart");

            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Complete()
        {
            var model = new ShippingDetailViewModel()
            {
                shippingDetail = new ShippingDetail()
            };
            return View(model);
        }

        [HttpPost]

        public IActionResult Complete(ShippingDetail shippingDetail)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", "Shipping completed");
            _cartSessionHelper.Clear();
            return RedirectToAction("Index", "Product");
        }
    }
}
