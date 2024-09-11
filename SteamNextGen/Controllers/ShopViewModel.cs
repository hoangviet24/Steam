using SteamNextGen.Models;

namespace SteamNextGen.Controllers
{
    internal class ShopViewModel
    {
        public IEnumerable<Product> CarouselProducts { get; set; }
        public IEnumerable<Product> AllProducts { get; set; }
    }
}