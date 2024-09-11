namespace SteamNextGen.Models
{
    internal class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public float Price { get; set; }
        public bool IsOwned { get; set; }
    }
}