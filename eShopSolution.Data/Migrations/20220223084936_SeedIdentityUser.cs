using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 15, 49, 36, 106, DateTimeKind.Local).AddTicks(9566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 15, 32, 4, 896, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("f440ed41-9437-4466-91cf-621d63744e96"), "e618453f-909d-4201-979a-90e503b84f63", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("6ecec09b-633f-44b3-80bd-cf8df0fffa70"), new Guid("f440ed41-9437-4466-91cf-621d63744e96") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("6ecec09b-633f-44b3-80bd-cf8df0fffa70"), 0, "cbbb733a-1741-4e3c-8126-fe500df1f898", new DateTime(2000, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "unicornstore512@gmail.com", true, "Liem", "Nguyen", false, null, "unicornstore512@gmail.com", "admin", "AQAAAAEAACcQAAAAEJMZ/tYQJI315u6cafWutt7GxJTkCt/vde7i0k0bYi0a5khEkb3roVSgpBKXuNBGjg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 23, 15, 49, 36, 121, DateTimeKind.Local).AddTicks(9003));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f440ed41-9437-4466-91cf-621d63744e96"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("6ecec09b-633f-44b3-80bd-cf8df0fffa70"), new Guid("f440ed41-9437-4466-91cf-621d63744e96") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6ecec09b-633f-44b3-80bd-cf8df0fffa70"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 15, 32, 4, 896, DateTimeKind.Local).AddTicks(7033),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 2, 23, 15, 49, 36, 106, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 23, 15, 32, 4, 912, DateTimeKind.Local).AddTicks(4510));
        }
    }
}
