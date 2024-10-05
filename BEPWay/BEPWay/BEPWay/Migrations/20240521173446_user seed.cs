using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEPWay.Migrations
{
    public partial class userseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("5e89ff39-452a-422b-9a70-de023150e2ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3481), new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("605c64c8-ed72-4f57-af1f-a700f35355e6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3492), new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("db8eb400-822e-4794-a176-42a3f4f93af6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3471), new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("f0f4e275-1de5-41f6-bc13-f66021a7b004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3487), new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("07da424c-1b7f-407e-be59-908884b25015"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("b2f21012-62cf-4467-bc68-ad40d81ccd4c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3313), new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e911932a-0de2-4d8d-9ccd-5950b91d79cd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3324), new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("fb9081b9-eedd-4db5-a868-ea512d15374c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3319), new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a5bc3de4-862e-475a-897c-67edfdd6b20e"), true, new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3551), "Admin", "Admin", new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3552), "Admin" },
                    { new Guid("cb9ff0ab-26b7-43f2-a655-76f97ea65e63"), true, new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3559), "Admin", "Customer", new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3560), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "CNIC", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "FatherName", "MobileNo", "Name", "Password", "UpdatedAt", "UpdatedBy", "UserName" },
                values: new object[] { new Guid("cdab35de-e131-484c-9b33-8cb210af0beb"), true, "123132433231", new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3607), "Admin", new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3604), "admin@gmail.com", "Admin", "03005019767", "Admin", "Admin", new DateTime(2024, 5, 21, 22, 34, 45, 152, DateTimeKind.Local).AddTicks(3608), "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5bc3de4-862e-475a-897c-67edfdd6b20e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cb9ff0ab-26b7-43f2-a655-76f97ea65e63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdab35de-e131-484c-9b33-8cb210af0beb"));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("5e89ff39-452a-422b-9a70-de023150e2ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7888), new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("605c64c8-ed72-4f57-af1f-a700f35355e6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7896), new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("db8eb400-822e-4794-a176-42a3f4f93af6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7879), new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("f0f4e275-1de5-41f6-bc13-f66021a7b004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7892), new DateTime(2024, 5, 20, 20, 10, 16, 266, DateTimeKind.Local).AddTicks(7893) });

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
    }
}
