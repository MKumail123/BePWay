using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEPWay.Migrations
{
    public partial class UserRoleseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles");

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("5e89ff39-452a-422b-9a70-de023150e2ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("605c64c8-ed72-4f57-af1f-a700f35355e6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4702), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("db8eb400-822e-4794-a176-42a3f4f93af6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("f0f4e275-1de5-41f6-bc13-f66021a7b004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4693), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("07da424c-1b7f-407e-be59-908884b25015"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4433), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("b2f21012-62cf-4467-bc68-ad40d81ccd4c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4473), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e911932a-0de2-4d8d-9ccd-5950b91d79cd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4491), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("fb9081b9-eedd-4db5-a868-ea512d15374c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4483), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5bc3de4-862e-475a-897c-67edfdd6b20e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cb9ff0ab-26b7-43f2-a655-76f97ea65e63"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4795), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "RoleId", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("b360eb40-3220-4a22-b5d9-d6b4625fda08"), true, new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4918), "Admin", new Guid("a5bc3de4-862e-475a-897c-67edfdd6b20e"), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4920), "Admin", new Guid("cdab35de-e131-484c-9b33-8cb210af0beb") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdab35de-e131-484c-9b33-8cb210af0beb"),
                columns: new[] { "CreatedAt", "DateOfBirth", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4859), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("b360eb40-3220-4a22-b5d9-d6b4625fda08"));

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("5e89ff39-452a-422b-9a70-de023150e2ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7054), new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("605c64c8-ed72-4f57-af1f-a700f35355e6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7062), new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("db8eb400-822e-4794-a176-42a3f4f93af6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7045), new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("f0f4e275-1de5-41f6-bc13-f66021a7b004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7058), new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("07da424c-1b7f-407e-be59-908884b25015"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(6920), new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("b2f21012-62cf-4467-bc68-ad40d81ccd4c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(6939), new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e911932a-0de2-4d8d-9ccd-5950b91d79cd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(6948), new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("fb9081b9-eedd-4db5-a868-ea512d15374c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(6943), new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5bc3de4-862e-475a-897c-67edfdd6b20e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7097), new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cb9ff0ab-26b7-43f2-a655-76f97ea65e63"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7103), new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdab35de-e131-484c-9b33-8cb210af0beb"),
                columns: new[] { "CreatedAt", "DateOfBirth", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7132), new DateTime(2024, 5, 21, 23, 40, 3, 299, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }
    }
}
