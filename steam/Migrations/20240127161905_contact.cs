using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace steam.Migrations
{
    /// <inheritdoc />
    public partial class contact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.CreateTable(
                name: "contacts",
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
                    table.PrimaryKey("PK_contacts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://scontent.fsgn8-2.fna.fbcdn.net/v/t39.30808-6/423194553_1837787356671489_8732348031602822991_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=3635dc&_nc_eui2=AeGkqocLh0d3WbNv0uW4vZBw1Y9YEbQ7yanVj1gRtDvJqVF_s1-zFr_j9jx2XytTyG5uOYN-77a3MKhLG40MsIX2&_nc_ohc=CqyfYv_aobMAX-6ugc2&_nc_ht=scontent.fsgn8-2.fna&oh=00_AfAnbsKZGpUoeYkr1024liWsxMhrSaHew_N8Av2DZNQglw&oe=65B98B97");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Detail", "ImageUrl", "Name", "Price" },
                values: new object[] { "Sản phẩm bắn súng hay nhất mọi thời đại", "https://scontent.fsgn13-3.fna.fbcdn.net/v/t39.30808-6/423132207_1837787330004825_4872656706903582606_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=3635dc&_nc_eui2=AeG0xN6_PMJyKezhTspFIEZqUrTRBkypF2NStNEGTKkXY-_ypQxXJrq6NHMOTYXghiqCQZWBjFi_3PgBjUp--jhT&_nc_ohc=B6YE300i-PoAX8AGBjN&_nc_ht=scontent.fsgn13-3.fna&oh=00_AfCF9OnlJXjYtpeRCGBvh5KFWYnxXlQ30fXCy2uWxE80cw&oe=65B95480", "Call of Duty: MW2", 1039000f });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Detail", "ImageUrl", "Name", "Price" },
                values: new object[] { "Nơi mà phản diện phải chạy trốn chính diện", "https://www.facebook.com/68ebb2aa-6122-49a7-a412-2c293302fd67", "DOOM", 750000f });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Detail", "ImageUrl", "Name", "Price" },
                values: new object[] { "Vị vua ngủ quên", "https://www.facebook.com/34eae0fd-4e55-4360-99a4-c077d48eb3f3", "PUBG: BATTLE GROUND", 0f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.facebook.com/384dc6ac-8ec5-4142-a956-765ef40eb0c0");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Detail", "ImageUrl", "Name", "Price" },
                values: new object[] { "Là con của LoL nhưng lúc nào cũng kêu bố nhái con", "https://www.facebook.com/384dc6ac-8ec5-4142-a956-765ef40eb0c0", "Arena of Valor", 0f });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Detail", "ImageUrl", "Name", "Price" },
                values: new object[] { "Sản phẩm bắn súng hay nhất mọi thời đại", "https://www.facebook.com/9a6ff2f0-2458-4ed5-aa19-16b07c0e6eb5", "Call of Duty: MW2", 1039000f });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Detail", "ImageUrl", "Name", "Price" },
                values: new object[] { "Nơi mà phản diện phải chạy trốn chính diện", "https://www.facebook.com/68ebb2aa-6122-49a7-a412-2c293302fd67", "DOOM", 750000f });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Detail", "ImageUrl", "Name", "Price", "isTopPlayProduct", "isTopSaleProduct", "isTrendingProduct" },
                values: new object[] { 6, "Vị vua ngủ quên", "https://www.facebook.com/34eae0fd-4e55-4360-99a4-c077d48eb3f3", "PUBG: BATTLE GROUND", 0f, false, false, false });
        }
    }
}
