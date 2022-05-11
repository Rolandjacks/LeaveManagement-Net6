using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bac44a6e-b7cc-4448-badf-1cdd267badde", "5e0436a6-70f1-4239-ac04-a9446f43eff2", "User", "USER" },
                    { "cac41a6e-a7bb-4448-baad-1add414ccbbf", "0839e4be-07d1-4c65-b90b-126c9618088d", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "acb23a7e-b4cc-3724-bccd-3bdd229cc882", 0, "76da4954-b7d7-4e44-a74e-4a30c3d5ff18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEL1qgRr6nqKNFExGF460VlN8x41Qh1TKLmdX6YQs/LH8qzxRJ2g34dUwD56r+yNBcw==", null, false, "61539d7d-a447-45f6-af19-bb751610ea2a", null, false, null },
                    { "bac32a2e-b4aa-2437-baad-5bee229bb228", 0, "875271e7-2682-4be9-b34a-ffab105be596", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAELbGSktxXpjTiSm5DMtYzdJ3HUFLTID0zkTs5HtJxIJifUveg8IjqWI10FMAuaVUNw==", null, false, "90e32d68-f38f-49cd-b5b5-258c556ff088", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac41a6e-a7bb-4448-baad-1add414ccbbf", "acb23a7e-b4cc-3724-bccd-3bdd229cc882" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bac44a6e-b7cc-4448-badf-1cdd267badde", "bac32a2e-b4aa-2437-baad-5bee229bb228" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac41a6e-a7bb-4448-baad-1add414ccbbf", "acb23a7e-b4cc-3724-bccd-3bdd229cc882" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bac44a6e-b7cc-4448-badf-1cdd267badde", "bac32a2e-b4aa-2437-baad-5bee229bb228" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bac44a6e-b7cc-4448-badf-1cdd267badde");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac41a6e-a7bb-4448-baad-1add414ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb23a7e-b4cc-3724-bccd-3bdd229cc882");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bac32a2e-b4aa-2437-baad-5bee229bb228");

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
