using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bac44a6e-b7cc-4448-badf-1cdd267badde",
                column: "ConcurrencyStamp",
                value: "9085ad83-9c94-4bdb-bed1-c78c666b53da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac41a6e-a7bb-4448-baad-1add414ccbbf",
                column: "ConcurrencyStamp",
                value: "9445b5af-e038-4daa-8dd3-23e03721f10e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb23a7e-b4cc-3724-bccd-3bdd229cc882",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f6c8f27-b902-44df-bf33-7de799ef2f57", "AQAAAAEAACcQAAAAEJGiJS2ircPHp6plR+yTXM/0ln6Ly3VcUrqmPuPt4FVsIIUitxsVCDd9I7aO1YAGTg==", "e503462a-5462-4019-b7ef-8fcf5c139788" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bac32a2e-b4aa-2437-baad-5bee229bb228",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca8f6d17-2a83-403d-863b-4d0ffbdc3188", "AQAAAAEAACcQAAAAEHW4r7FuPy8Yfzq3/n2RM5c/1bbxN5wbewps8beaAV5SNQN7Sn1AEviKLW1QXJt75w==", "75a5611e-852f-44f2-8612-c60fec0206c0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b02e7837-d98f-4ebb-ac73-a2e379566366", "AQAAAAEAACcQAAAAENaYlsYgJmchFDxnc6XzharAhXCMdxDxeMun/At8imO0/5Mnu6DxSGpvJbzyFCZ89g==", "69a23ecb-1c7a-4e72-8cec-acfe95c28a2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bac32a2e-b4aa-2437-baad-5bee229bb228",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba827201-8e8d-417e-b656-e9866db36d90", "AQAAAAEAACcQAAAAEP7psmGEEM0ka7dmGCGTSnfuOikAzbU6Vm7zfIs9lQ0T4X+J8KCrrBO8CTNbxwVQig==", "bb77d6d1-fb6c-472b-bf7c-536aec4a98fd" });
        }
    }
}
