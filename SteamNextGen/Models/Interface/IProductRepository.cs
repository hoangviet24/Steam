namespace SteamNextGen.Models.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetTrendingProducts();
        IEnumerable<Product> GetTopSaleProducts();
        IEnumerable<Product> GetTopPlayProducts();
        Product GetProductDetail(int id);
    }
}
