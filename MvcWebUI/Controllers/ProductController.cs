using Bussines.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class ProductController:Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;   
        }

        public IActionResult Index(int category) // model enc ındex içinde olmalı
        {
            var model = new ProductControllerViewModel
            {
                Products = category>0?_productService.GetById(category): _productService.GetAll()
            };
              

            return View(model);
        }
    }
}
