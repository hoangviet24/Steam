using Microsoft.EntityFrameworkCore;
using SteamNextGen.Data;
using SteamNextGen.Models.Interface;
namespace SteamNextGen.Models.Services
{
    public class ShoppingCartRepository:IShoppingCartRepository
    {
        private SteamDBContext dbContext;
        public ShoppingCartRepository(SteamDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<TTTM>? ShoppingCartItems { get; set; }
        public string? ShoppingCartId { set; get; }
        public static ShoppingCartRepository GetCart(IServiceProvider services)
        {
            ISession? session =
           services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            SteamDBContext context = services.GetService<SteamDBContext>() ??
           throw new Exception("Error initializing coffeeshopdbcontext");
            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();
            session?.SetString("CartId", cartId);
            return new ShoppingCartRepository(context) { ShoppingCartId = cartId };
        }
        public void AddToCart(Product product)
        {
            var shoppingCartItem = dbContext.tttm.FirstOrDefault(s =>
           s.Product.Id == product.Id && s.ShoppingCartId == ShoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new TTTM
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                };
                dbContext.tttm.Add(shoppingCartItem);
            }
            dbContext.SaveChanges();
        }
        public void ClearCart()
        {
            var cartItems = dbContext.tttm.Where(s => s.ShoppingCartId ==ShoppingCartId);
            dbContext.tttm.RemoveRange(cartItems);
            dbContext.SaveChanges();
        }
        public List<TTTM> GetAllShoppingCartItems()
        {
            return ShoppingCartItems ??= dbContext.tttm.Where(s =>
           s.ShoppingCartId == ShoppingCartId).Include(p => p.Product).ToList();
        }
        public decimal GetShoppingCartTotal()
        {
            var totalCost = dbContext.tttm.Where(s => s.ShoppingCartId ==
           ShoppingCartId)
            .Select(s => s.Product.Price).Sum();
            return (decimal)totalCost;
        }
        public int RemoveFromCart(Product product)
        {
            var shoppingCartItem = dbContext.tttm.FirstOrDefault(s =>
           s.Product.Id == product.Id && s.ShoppingCartId == ShoppingCartId);
            var quantity = 0;
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Qty > 1)
                {
                    shoppingCartItem.Qty = shoppingCartItem.Qty - shoppingCartItem.Qty;
                    quantity = shoppingCartItem.Qty;
                }
                else
                {
                    dbContext.tttm.Remove(shoppingCartItem);
                }
            }
            dbContext.SaveChanges();
            return quantity;
        }
    }
}
