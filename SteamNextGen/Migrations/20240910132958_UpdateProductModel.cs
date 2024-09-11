using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamNextGen.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://scontent.fsgn8-2.fna.fbcdn.net/v/t39.30808-6/423194553_1837787356671489_8732348031602822991_n.jpg?stp=dst-jpg_s600x600&_nc_cat=100&ccb=1-7&_nc_sid=127cfc&_nc_ohc=HELe27VrNcYQ7kNvgFgs7Ns&_nc_ht=scontent.fsgn8-2.fna&_nc_gid=AVRnMjWqnFngYQqnfxCON9R&oh=00_AYCk2dqOdpU47ohPEsnlJ3gel0Xudeg6lAVfpmqEbzCS1g&oe=66E5E957");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://scontent.fsgn8-2.fna.fbcdn.net/v/t39.30808-6/423194553_1837787356671489_8732348031602822991_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=3635dc&_nc_ohc=K6GB57jAuzIAX9EjOhL&_nc_ht=scontent.fsgn8-2.fna&oh=00_AfDtcstwEg_V4B9AEClDlJSq0Eyp1amsjhThADTR4PX5dA&oe=65DD2417");
        }
    }
}
