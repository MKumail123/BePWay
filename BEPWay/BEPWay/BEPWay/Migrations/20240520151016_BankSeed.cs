using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEPWay.Migrations
{
    public partial class BankSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransactionId",
                table: "UserPackages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "Id", "AccountNo", "AccountTitle", "Active", "BankName", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("5e89ff39-452a-422b-9a70-de023150e2ec"), "03098379012", "Nalain Abbas", true, "Jazzcash", new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7888), "Admin", new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7889), "Admin" },
                    { new Guid("605c64c8-ed72-4f57-af1f-a700f35355e6"), "03098379012", "Nalain Abbas", true, "Sadapay", new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7896), "Admin", new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7897), "Admin" },
                    { new Guid("db8eb400-822e-4794-a176-42a3f4f93af6"), "03205001894", "Taimoor Haider Shah", true, "Easypaisa", new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7879), "Admin", new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7880), "Admin" },
                    { new Guid("f0f4e275-1de5-41f6-bc13-f66021a7b004"), "01210010080914760010", "Sohail Ahmed", true, "Allied Bank", new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7892), "Admin", new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7893), "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("07da424c-1b7f-407e-be59-908884b25015"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7743), new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("b2f21012-62cf-4467-bc68-ad40d81ccd4c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7765), new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e911932a-0de2-4d8d-9ccd-5950b91d79cd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7774), new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("fb9081b9-eedd-4db5-a868-ea512d15374c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7770), new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7771) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("5e89ff39-452a-422b-9a70-de023150e2ec"));

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("605c64c8-ed72-4f57-af1f-a700f35355e6"));

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("db8eb400-822e-4794-a176-42a3f4f93af6"));

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("f0f4e275-1de5-41f6-bc13-f66021a7b004"));

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "UserPackages");

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("07da424c-1b7f-407e-be59-908884b25015"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8572), new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("b2f21012-62cf-4467-bc68-ad40d81ccd4c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8600), new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e911932a-0de2-4d8d-9ccd-5950b91d79cd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8614), new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("fb9081b9-eedd-4db5-a868-ea512d15374c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8608), new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8610) });
        }
    }
}
