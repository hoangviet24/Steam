using Microsoft.AspNetCore.Mvc;
using steam.Models;
using steam.Models.Interface;
using System.Diagnostics;

namespace steam.Controllers
{
    public class ProductController : Controller
    {
        
        public IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public IActionResult Detail(int id)
        {
            var product = _productRepository.GetProductDetail(id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }
        public IActionResult Shop()
        {
            return View(_productRepository.GetTopPlayProducts());
        }
    }
}
