
using Microsoft.AspNetCore.Mvc;
using SteamNextGen.Models.Interface;
using SteamNextGen.Models;
using SteamNextGen.Models.Services;
using Microsoft.AspNetCore.Authorization;
namespace coffeeshop.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private IOrderRepository orderRepository;
        private IShoppingCartRepository shoppingCartRepository;
        public OrderController(IOrderRepository oderRepository,
       IShoppingCartRepository shoppingCartRepossitory)
        {
            this.orderRepository = oderRepository;
            this.shoppingCartRepository = shoppingCartRepossitory;
        }
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            orderRepository.PlaceOrder(order);
            shoppingCartRepository.ClearCart();
            HttpContext.Session.SetInt32("CartCount", 0);
            return RedirectToAction("CheckoutComplete");
           
        }
        public IActionResult CheckoutComplete()
        {
            return View();
        }
    }
}


