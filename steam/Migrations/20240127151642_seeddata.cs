using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace steam.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Detail", "ImageUrl", "Name", "Price", "isTopPlayProduct", "isTopSaleProduct", "isTrendingProduct" },
                values: new object[,]
                {
                    { 1, "Một tựa game Esport ", "https://www.facebook.com/384dc6ac-8ec5-4142-a956-765ef40eb0c0", "Counter Strike", 0f, false, false, false },
                    { 2, "Đến từ nhà làm game với kinh nghiệm 200 năm:))", "https://www.facebook.com/b3ed0f08-f5d7-406e-a84a-7f42f55156aa", "Leauge of Legend", 0f, false, false, false },
                    { 3, "Là con của LoL nhưng lúc nào cũng kêu bố nhái con", "https://www.facebook.com/384dc6ac-8ec5-4142-a956-765ef40eb0c0", "Arena of Valor", 0f, false, false, false },
                    { 4, "Sản phẩm bắn súng hay nhất mọi thời đại", "https://www.facebook.com/9a6ff2f0-2458-4ed5-aa19-16b07c0e6eb5", "Call of Duty: MW2", 1039000f, false, false, false },
                    { 5, "Nơi mà phản diện phải chạy trốn chính diện", "https://www.facebook.com/68ebb2aa-6122-49a7-a412-2c293302fd67", "DOOM", 750000f, false, false, false },
                    { 6, "Vị vua ngủ quên", "https://www.facebook.com/34eae0fd-4e55-4360-99a4-c077d48eb3f3", "PUBG: BATTLE GROUND", 0f, false, false, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
