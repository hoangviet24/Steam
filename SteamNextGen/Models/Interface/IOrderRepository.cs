using Microsoft.AspNetCore.Identity;

namespace SteamNextGen.Models.Interface
{
    public interface IOrderRepository
    {
        public void PlaceOrder(Order order);
    }
}
