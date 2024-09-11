using SteamNextGen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace SteamNextGen.Data
{
    public class SteamDBContext : IdentityDbContext<IdentityUser>
    {
        public SteamDBContext(DbContextOptions<SteamDBContext> options) : base(options) { }
        public DbSet<Product> Product { get; set; }
        public DbSet<TTTM> tttm { get; set; }
        public DbSet<Order> orders { get; set; }
        public object Orders { get; internal set; }
        public DbSet<OrderDetail> orderDetail { get; set; }
        public DbSet<Contact> contact { get; set; }
        public IEnumerable<object> OrderDetails { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Counter Strike", Price = 0, Detail = "Một tựa game Esport ", ImageUrl = "https://scontent.fsgn8-2.fna.fbcdn.net/v/t39.30808-6/423194553_1837787356671489_8732348031602822991_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=127cfc&_nc_ohc=HELe27VrNcYQ7kNvgFgs7Ns&_nc_ht=scontent.fsgn8-2.fna&_nc_gid=AVRnMjWqnFngYQqnfxCON9R&oh=00_AYCk2dqOdpU47ohPEsnlJ3gel0Xudeg6lAVfpmqEbzCS1g&oe=66E5E957" },
            new Product { Id = 2, Name = "Leauge of Legend", Price = 0, Detail = "Đến từ nhà làm game với kinh nghiệm 200 năm:))", ImageUrl = "https://scontent.fsgn13-4.fna.fbcdn.net/v/t39.30808-6/423132886_1837787393338152_4729330446516627735_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=3635dc&_nc_ohc=qCpbWJe-k7sAX-GrOtH&_nc_ht=scontent.fsgn13-4.fna&oh=00_AfDKFHbelOCbpZrV-qhLCIwy0fPlbZY5v7nDvTmfmQjp4g&oe=65DDAE3D" },
            new Product { Id = 3, Name = "Call of Duty: MW2", Price = 1039000, Detail = "Sản phẩm bắn súng hay nhất mọi thời đại", ImageUrl = "https://scontent.fsgn13-3.fna.fbcdn.net/v/t39.30808-6/423132207_1837787330004825_4872656706903582606_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=3635dc&_nc_ohc=M17RdJqPvW0AX-_lsXz&_nc_ht=scontent.fsgn13-3.fna&oh=00_AfCwaoOIzfm_A1MX1KbMMKGxCpoiqrUcNzxk0d70s-tV_g&oe=65DCED00" },
            new Product { Id = 4, Name = "DOOM", Price = 750000, Detail = "Nơi mà phản diện phải chạy trốn chính diện", ImageUrl = "https://scontent.fsgn4-1.fna.fbcdn.net/v/t39.30808-6/423160643_1837787333338158_7206239327615406526_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=3635dc&_nc_ohc=YJ0yUVfeBCQAX9bO_xN&_nc_ht=scontent.fsgn4-1.fna&oh=00_AfA8GwT6abF2dAGl9lGyD5M3UzKIGCRS5qFH5G-XIhoWlg&oe=65DDBFEF" },
            new Product { Id = 5, Name = "PUBG: BATTLE GROUND", Price = 0, Detail = "Vị vua ngủ quên", ImageUrl = "https://scontent.fsgn13-3.fna.fbcdn.net/v/t39.30808-6/423133246_1837787683338123_1472723522760642454_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=3635dc&_nc_ohc=qXzcqKhIclYAX9kHIrZ&_nc_ht=scontent.fsgn13-3.fna&oh=00_AfCyG3IJsLxSMVeISz2WHI__1ltFbXAiaclOLLGdPFNBoQ&oe=65DCD4A3" }
            );
        }
    }
}
