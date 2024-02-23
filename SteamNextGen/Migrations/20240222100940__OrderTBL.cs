using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamNextGen.Migrations
{
    /// <inheritdoc />
    public partial class _OrderTBL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "orders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
