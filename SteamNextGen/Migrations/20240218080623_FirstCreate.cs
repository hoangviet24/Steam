using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SteamNextGen.Migrations
{
    /// <inheritdoc />
    public partial class FirstCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mess = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    isTrendingProduct = table.Column<bool>(type: "bit", nullable: false),
                    isTopSaleProduct = table.Column<bool>(type: "bit", nullable: false),
                    isTopPlayProduct = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Detail", "ImageUrl", "Name", "Price", "isTopPlayProduct", "isTopSaleProduct", "isTrendingProduct" },
                values: new object[,]
                {
                    { 1, "Một tựa game Esport ", "https://scontent.fsgn8-2.fna.fbcdn.net/v/t39.30808-6/423194553_1837787356671489_8732348031602822991_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=3635dc&_nc_eui2=AeGkqocLh0d3WbNv0uW4vZBw1Y9YEbQ7yanVj1gRtDvJqVF_s1-zFr_j9jx2XytTyG5uOYN-77a3MKhLG40MsIX2&_nc_ohc=CqyfYv_aobMAX-6ugc2&_nc_ht=scontent.fsgn8-2.fna&oh=00_AfAnbsKZGpUoeYkr1024liWsxMhrSaHew_N8Av2DZNQglw&oe=65B98B97", "Counter Strike", 0f, false, false, false },
                    { 2, "Đến từ nhà làm game với kinh nghiệm 200 năm:))", "https://www.facebook.com/b3ed0f08-f5d7-406e-a84a-7f42f55156aa", "Leauge of Legend", 0f, false, false, false },
                    { 3, "Sản phẩm bắn súng hay nhất mọi thời đại", "https://scontent.fsgn13-3.fna.fbcdn.net/v/t39.30808-6/423132207_1837787330004825_4872656706903582606_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=3635dc&_nc_eui2=AeG0xN6_PMJyKezhTspFIEZqUrTRBkypF2NStNEGTKkXY-_ypQxXJrq6NHMOTYXghiqCQZWBjFi_3PgBjUp--jhT&_nc_ohc=B6YE300i-PoAX8AGBjN&_nc_ht=scontent.fsgn13-3.fna&oh=00_AfCF9OnlJXjYtpeRCGBvh5KFWYnxXlQ30fXCy2uWxE80cw&oe=65B95480", "Call of Duty: MW2", 1039000f, false, false, false },
                    { 4, "Nơi mà phản diện phải chạy trốn chính diện", "https://www.facebook.com/68ebb2aa-6122-49a7-a412-2c293302fd67", "DOOM", 750000f, false, false, false },
                    { 5, "Vị vua ngủ quên", "https://www.facebook.com/34eae0fd-4e55-4360-99a4-c077d48eb3f3", "PUBG: BATTLE GROUND", 0f, false, false, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contact");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
