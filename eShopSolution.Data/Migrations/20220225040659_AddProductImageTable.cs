using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 15, 49, 36, 106, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    isDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f440ed41-9437-4466-91cf-621d63744e96"),
                column: "ConcurrencyStamp",
                value: "69c72371-4f69-431f-a6e8-a8245b94c0aa");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6ecec09b-633f-44b3-80bd-cf8df0fffa70"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa152f13-094e-4d90-9c25-4c96b6a39dd8", "AQAAAAEAACcQAAAAENiC+KWW1x8rs5k9p+NlibkYypGK2hkDjATs1ziyGIq6lnaTbwXZ2od/en5KeQyqmA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 25, 11, 6, 58, 621, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 15, 49, 36, 106, DateTimeKind.Local).AddTicks(9566),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f440ed41-9437-4466-91cf-621d63744e96"),
                column: "ConcurrencyStamp",
                value: "e618453f-909d-4201-979a-90e503b84f63");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6ecec09b-633f-44b3-80bd-cf8df0fffa70"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbbb733a-1741-4e3c-8126-fe500df1f898", "AQAAAAEAACcQAAAAEJMZ/tYQJI315u6cafWutt7GxJTkCt/vde7i0k0bYi0a5khEkb3roVSgpBKXuNBGjg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 23, 15, 49, 36, 121, DateTimeKind.Local).AddTicks(9003));
        }
    }
}
