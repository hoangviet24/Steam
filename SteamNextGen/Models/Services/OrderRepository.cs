using Microsoft.EntityFrameworkCore;
using SteamNextGen.Data;
using SteamNextGen.Models.Interface;
namespace SteamNextGen.Models.Services
{
    public class OrderRepository : IOrderRepository
    {
        private SteamDBContext _dbContext;
        private IShoppingCartRepository _shoppingCartRepository;
        public TTTM tTTM ;
        public OrderRepository(SteamDBContext dbContext, IShoppingCartRepository shoppingCartRepository)
        {
            _dbContext = dbContext;
            _shoppingCartRepository = shoppingCartRepository;
        }
        public void PlaceOrder(Order order)
        {
            var shoppingCartItems = _shoppingCartRepository.GetAllShoppingCartItems();
            order.OrderDetails = new List<OrderDetail>();
            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Quantity = item.Qty,
                    ProductId = item.Product.Id,
                    Price = (decimal)item.Product.Price,
                };
                order.OrderDetails.Add(orderDetail);
            }
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCartRepository.GetShoppingCartTotal();
            _dbContext.orders.Add(order);
            _dbContext.SaveChanges();
        }
    }
}
