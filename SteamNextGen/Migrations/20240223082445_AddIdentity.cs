using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamNextGen.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://scontent.fsgn8-2.fna.fbcdn.net/v/t39.30808-6/423194553_1837787356671489_8732348031602822991_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=3635dc&_nc_ohc=K6GB57jAuzIAX9EjOhL&_nc_ht=scontent.fsgn8-2.fna&oh=00_AfDtcstwEg_V4B9AEClDlJSq0Eyp1amsjhThADTR4PX5dA&oe=65DD2417");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://scontent.fsgn13-4.fna.fbcdn.net/v/t39.30808-6/423132886_1837787393338152_4729330446516627735_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=3635dc&_nc_ohc=qCpbWJe-k7sAX-GrOtH&_nc_ht=scontent.fsgn13-4.fna&oh=00_AfDKFHbelOCbpZrV-qhLCIwy0fPlbZY5v7nDvTmfmQjp4g&oe=65DDAE3D");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://scontent.fsgn13-3.fna.fbcdn.net/v/t39.30808-6/423132207_1837787330004825_4872656706903582606_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=3635dc&_nc_ohc=M17RdJqPvW0AX-_lsXz&_nc_ht=scontent.fsgn13-3.fna&oh=00_AfCwaoOIzfm_A1MX1KbMMKGxCpoiqrUcNzxk0d70s-tV_g&oe=65DCED00");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://scontent.fsgn4-1.fna.fbcdn.net/v/t39.30808-6/423160643_1837787333338158_7206239327615406526_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=3635dc&_nc_ohc=YJ0yUVfeBCQAX9bO_xN&_nc_ht=scontent.fsgn4-1.fna&oh=00_AfA8GwT6abF2dAGl9lGyD5M3UzKIGCRS5qFH5G-XIhoWlg&oe=65DDBFEF");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://scontent.fsgn13-3.fna.fbcdn.net/v/t39.30808-6/423133246_1837787683338123_1472723522760642454_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=3635dc&_nc_ohc=qXzcqKhIclYAX9kHIrZ&_nc_ht=scontent.fsgn13-3.fna&oh=00_AfCyG3IJsLxSMVeISz2WHI__1ltFbXAiaclOLLGdPFNBoQ&oe=65DCD4A3");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://scontent.fsgn8-2.fna.fbcdn.net/v/t39.30808-6/423194553_1837787356671489_8732348031602822991_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=3635dc&_nc_eui2=AeGkqocLh0d3WbNv0uW4vZBw1Y9YEbQ7yanVj1gRtDvJqVF_s1-zFr_j9jx2XytTyG5uOYN-77a3MKhLG40MsIX2&_nc_ohc=CqyfYv_aobMAX-6ugc2&_nc_ht=scontent.fsgn8-2.fna&oh=00_AfAnbsKZGpUoeYkr1024liWsxMhrSaHew_N8Av2DZNQglw&oe=65B98B97");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.facebook.com/b3ed0f08-f5d7-406e-a84a-7f42f55156aa");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://scontent.fsgn13-3.fna.fbcdn.net/v/t39.30808-6/423132207_1837787330004825_4872656706903582606_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=3635dc&_nc_eui2=AeG0xN6_PMJyKezhTspFIEZqUrTRBkypF2NStNEGTKkXY-_ypQxXJrq6NHMOTYXghiqCQZWBjFi_3PgBjUp--jhT&_nc_ohc=B6YE300i-PoAX8AGBjN&_nc_ht=scontent.fsgn13-3.fna&oh=00_AfCF9OnlJXjYtpeRCGBvh5KFWYnxXlQ30fXCy2uWxE80cw&oe=65B95480");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.facebook.com/68ebb2aa-6122-49a7-a412-2c293302fd67");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.facebook.com/34eae0fd-4e55-4360-99a4-c077d48eb3f3");
        }
    }
}
