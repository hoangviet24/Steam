using Microsoft.AspNetCore.Mvc;
using SteamNextGen.Models.Interface;
using System.Diagnostics;

namespace SteamNextGen.Controllers
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
            return View(_productRepository.GetTrendingProducts());
        }
        public IActionResult TopPlay()
        {
            return View(_productRepository.GetTopPlayProducts());
        }
        public IActionResult TopSale()
        {
            return View(_productRepository.GetTopSaleProducts());
        }
    }
}
