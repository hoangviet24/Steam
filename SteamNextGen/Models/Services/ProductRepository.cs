using SteamNextGen.Data;
using SteamNextGen.Models.Interface;

namespace SteamNextGen.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private SteamDBContext dbContext;
        public ProductRepository(SteamDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Product;
        }
        public Product GetProductDetail(int id)
        {
            return dbContext.Product.FirstOrDefault(p => p.Id == id);
        }
        
        public IEnumerable<Product> GetTopPlayProducts() => dbContext.Product.Where(p => p.isTopPlayProduct);

        public IEnumerable<Product> GetTopSaleProducts() => dbContext.Product.Where(p => p.isTopSaleProduct);

        public IEnumerable<Product> GetTrendingProducts() => dbContext.Product.Where(p => p.isTrendingProduct);

        public IEnumerable<Product> GetSellProducts() => dbContext.Product.Where(p => p.Price != 0);
        public IEnumerable<Product> GetFreeProducts() => dbContext.Product.Where(p => p.Price == 0);
    }
}
