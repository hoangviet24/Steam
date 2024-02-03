namespace steam.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl {  get; set; }
        public string Detail { get; set; }
        public float Price { get; set; }
        public bool isTrendingProduct { get; set; }
        public bool isTopSaleProduct {  get; set; }
        public bool isTopPlayProduct { get; set; }
    }
}
