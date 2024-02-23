using SteamNextGen.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;
using System.Reflection.Metadata;

namespace SteamNextGen.Data
{
    public class SteamDBContext : DbContext
    {
        public SteamDBContext(DbContextOptions<SteamDBContext> options) :base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<TTTM> tttm { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetail { get; set; }
        public DbSet<Contact> contact { get; set; }
       // public DbSet<Contact> contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Counter Strike", Price = 0, Detail = "Một tựa game Esport ", ImageUrl = "https://scontent.fsgn8-2.fna.fbcdn.net/v/t39.30808-6/423194553_1837787356671489_8732348031602822991_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=3635dc&_nc_eui2=AeGkqocLh0d3WbNv0uW4vZBw1Y9YEbQ7yanVj1gRtDvJqVF_s1-zFr_j9jx2XytTyG5uOYN-77a3MKhLG40MsIX2&_nc_ohc=CqyfYv_aobMAX-6ugc2&_nc_ht=scontent.fsgn8-2.fna&oh=00_AfAnbsKZGpUoeYkr1024liWsxMhrSaHew_N8Av2DZNQglw&oe=65B98B97" },
            new Product { Id = 2, Name = "Leauge of Legend", Price = 0, Detail = "Đến từ nhà làm game với kinh nghiệm 200 năm:))", ImageUrl = "https://www.facebook.com/b3ed0f08-f5d7-406e-a84a-7f42f55156aa" },
            new Product { Id = 3, Name = "Call of Duty: MW2", Price = 1039000, Detail = "Sản phẩm bắn súng hay nhất mọi thời đại", ImageUrl = "https://scontent.fsgn13-3.fna.fbcdn.net/v/t39.30808-6/423132207_1837787330004825_4872656706903582606_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=3635dc&_nc_eui2=AeG0xN6_PMJyKezhTspFIEZqUrTRBkypF2NStNEGTKkXY-_ypQxXJrq6NHMOTYXghiqCQZWBjFi_3PgBjUp--jhT&_nc_ohc=B6YE300i-PoAX8AGBjN&_nc_ht=scontent.fsgn13-3.fna&oh=00_AfCF9OnlJXjYtpeRCGBvh5KFWYnxXlQ30fXCy2uWxE80cw&oe=65B95480" },
            new Product { Id = 4, Name = "DOOM", Price = 750000, Detail = "Nơi mà phản diện phải chạy trốn chính diện", ImageUrl = "https://www.facebook.com/68ebb2aa-6122-49a7-a412-2c293302fd67" },
            new Product { Id = 5, Name = "PUBG: BATTLE GROUND", Price = 0, Detail = "Vị vua ngủ quên", ImageUrl = "https://www.facebook.com/34eae0fd-4e55-4360-99a4-c077d48eb3f3" }
            );
        }
    }
}
