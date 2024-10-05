using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEPWay.Migrations
{
    public partial class userroletable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("5e89ff39-452a-422b-9a70-de023150e2ec"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(189), new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("605c64c8-ed72-4f57-af1f-a700f35355e6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(202), new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("db8eb400-822e-4794-a176-42a3f4f93af6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(176), new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Banks",
                keyColumn: "Id",
                keyValue: new Guid("f0f4e275-1de5-41f6-bc13-f66021a7b004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(196), new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("07da424c-1b7f-407e-be59-908884b25015"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 20, 5, 515, DateTimeKind.Local).AddTicks(9939), new DateTime(2024, 5, 21, 23, 20, 5, 515, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("b2f21012-62cf-4467-bc68-ad40d81ccd4c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 20, 5, 515, DateTimeKind.Local).AddTicks(9972), new DateTime(2024, 5, 21, 23, 20, 5, 515, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("e911932a-0de2-4d8d-9ccd-5950b91d79cd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 20, 5, 515, DateTimeKind.Local).AddTicks(9986), new DateTime(2024, 5, 21, 23, 20, 5, 515, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("fb9081b9-eedd-4db5-a868-ea512d15374c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 20, 5, 515, DateTimeKind.Local).AddTicks(9979), new DateTime(2024, 5, 21, 23, 20, 5, 515, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5bc3de4-862e-475a-897c-67edfdd6b20e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(286), new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cb9ff0ab-26b7-43f2-a655-76f97ea65e63"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(298), new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdab35de-e131-484c-9b33-8cb210af0beb"),
                columns: new[] { "CreatedAt", "DateOfBirth", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(359), new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(357), new DateTime(2024, 5, 21, 23, 20, 5, 516, DateTimeKind.Local).AddTicks(362) });
        }
    }
}
