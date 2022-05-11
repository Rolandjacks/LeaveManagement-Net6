using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bac44a6e-b7cc-4448-badf-1cdd267badde",
                column: "ConcurrencyStamp",
                value: "bf69e4fd-6f44-4092-a714-019d029e77fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac41a6e-a7bb-4448-baad-1add414ccbbf",
                column: "ConcurrencyStamp",
                value: "35788b69-fcb1-46ad-b356-12acff1138ab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb23a7e-b4cc-3724-bccd-3bdd229cc882",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b02e7837-d98f-4ebb-ac73-a2e379566366", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAENaYlsYgJmchFDxnc6XzharAhXCMdxDxeMun/At8imO0/5Mnu6DxSGpvJbzyFCZ89g==", "69a23ecb-1c7a-4e72-8cec-acfe95c28a2c", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bac32a2e-b4aa-2437-baad-5bee229bb228",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ba827201-8e8d-417e-b656-e9866db36d90", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEP7psmGEEM0ka7dmGCGTSnfuOikAzbU6Vm7zfIs9lQ0T4X+J8KCrrBO8CTNbxwVQig==", "bb77d6d1-fb6c-472b-bf7c-536aec4a98fd", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bac44a6e-b7cc-4448-badf-1cdd267badde",
                column: "ConcurrencyStamp",
                value: "5e0436a6-70f1-4239-ac04-a9446f43eff2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac41a6e-a7bb-4448-baad-1add414ccbbf",
                column: "ConcurrencyStamp",
                value: "0839e4be-07d1-4c65-b90b-126c9618088d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb23a7e-b4cc-3724-bccd-3bdd229cc882",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "76da4954-b7d7-4e44-a74e-4a30c3d5ff18", false, null, "AQAAAAEAACcQAAAAEL1qgRr6nqKNFExGF460VlN8x41Qh1TKLmdX6YQs/LH8qzxRJ2g34dUwD56r+yNBcw==", "61539d7d-a447-45f6-af19-bb751610ea2a", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bac32a2e-b4aa-2437-baad-5bee229bb228",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "875271e7-2682-4be9-b34a-ffab105be596", false, null, "AQAAAAEAACcQAAAAELbGSktxXpjTiSm5DMtYzdJ3HUFLTID0zkTs5HtJxIJifUveg8IjqWI10FMAuaVUNw==", "90e32d68-f38f-49cd-b5b5-258c556ff088", null });
        }
    }
}
