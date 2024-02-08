namespace SteamNextGen.Models.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetTrendingProducts();
        IEnumerable<Product> GetTopSaleProducts();
        IEnumerable<Product> GetTopPlayProducts();
        IEnumerable<Product> GetSellProducts();
        IEnumerable<Product> GetFreeProducts();
        Product GetProductDetail(int id);
    }
}
