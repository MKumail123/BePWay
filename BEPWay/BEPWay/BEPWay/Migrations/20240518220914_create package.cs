using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEPWay.Migrations
{
    public partial class createpackage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "Active", "Amount", "CreatedAt", "CreatedBy", "Name", "Points", "UpdatedAt", "UpdatedBy", "Value" },
                values: new object[,]
                {
                    { new Guid("07da424c-1b7f-407e-be59-908884b25015"), true, 1500, new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8572), "Admin", "Basic Friendly", 15.0, new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8585), "Admin", 7.5 },
                    { new Guid("b2f21012-62cf-4467-bc68-ad40d81ccd4c"), true, 5250, new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8600), "Admin", "Advance Pro Bundle", 52.5, new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8601), "Admin", 26.25 },
                    { new Guid("e911932a-0de2-4d8d-9ccd-5950b91d79cd"), true, 19000, new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8614), "Admin", "Alpha Leadership Bundle", 190.0, new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8616), "Admin", 95.0 },
                    { new Guid("fb9081b9-eedd-4db5-a868-ea512d15374c"), true, 9000, new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8608), "Admin", "Premium Max Bundle", 90.0, new DateTime(2024, 5, 19, 3, 9, 13, 587, DateTimeKind.Local).AddTicks(8610), "Admin", 45.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("07da424c-1b7f-407e-be59-908884b25015"));

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("b2f21012-62cf-4467-bc68-ad40d81ccd4c"));

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e911932a-0de2-4d8d-9ccd-5950b91d79cd"));

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("fb9081b9-eedd-4db5-a868-ea512d15374c"));
        }
    }
}
