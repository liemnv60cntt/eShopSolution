using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDefault",
                table: "ProductImages",
                newName: "IsDefault");

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f440ed41-9437-4466-91cf-621d63744e96"),
                column: "ConcurrencyStamp",
                value: "7760fe1d-6cbc-49f9-85b1-3b9616061474");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6ecec09b-633f-44b3-80bd-cf8df0fffa70"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a0f21b4-6a42-4910-9e98-aa938abe319a", "AQAAAAEAACcQAAAAEIMCNmB6yyCu4rqQhmix7AcdUI+ZONyOuHsvS/ArypN70eJyaDyBHGknAUDrTYC2Zg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 21, 25, 7, 300, DateTimeKind.Local).AddTicks(1777));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDefault",
                table: "ProductImages",
                newName: "isDefault");

            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

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
        }
    }
}
