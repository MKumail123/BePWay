using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEPWay.Migrations
{
    public partial class activationpoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActivationPoints",
                table: "UserPackages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("5e89ff39-452a-422b-9a70-de023150e2ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4785), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("605c64c8-ed72-4f57-af1f-a700f35355e6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4795), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("db8eb400-822e-4794-a176-42a3f4f93af6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("f0f4e275-1de5-41f6-bc13-f66021a7b004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("07da424c-1b7f-407e-be59-908884b25015"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4667), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("b2f21012-62cf-4467-bc68-ad40d81ccd4c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4685), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e911932a-0de2-4d8d-9ccd-5950b91d79cd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4695), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("fb9081b9-eedd-4db5-a868-ea512d15374c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4691), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5bc3de4-862e-475a-897c-67edfdd6b20e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4830), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cb9ff0ab-26b7-43f2-a655-76f97ea65e63"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4836), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("b360eb40-3220-4a22-b5d9-d6b4625fda08"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4890), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdab35de-e131-484c-9b33-8cb210af0beb"),
                columns: new[] { "CreatedAt", "DateOfBirth", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4863), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4861), new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4864) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivationPoints",
                table: "UserPackages");

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

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("b360eb40-3220-4a22-b5d9-d6b4625fda08"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4918), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdab35de-e131-484c-9b33-8cb210af0beb"),
                columns: new[] { "CreatedAt", "DateOfBirth", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4859), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 5, 23, 21, 44, 1, 563, DateTimeKind.Local).AddTicks(4861) });
        }
    }
}
