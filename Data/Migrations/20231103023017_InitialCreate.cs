using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace blazor_server_dashboard.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AssignedBy", "AssignedTo", "CompletionDate", "Description", "DueDate", "Priority", "StartDate" },
                values: new object[,]
                {
                    { new Guid("187ee924-d6b9-4f5e-a421-ccb937de901f"), "Tammy Wescott", "Tammy Wescott", null, "Review code", new DateTime(2024, 10, 5, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4236), "low", new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4236) },
                    { new Guid("21d637eb-b0c5-4290-8962-0765baedf7be"), "Diane Basham", "Billy Dietz", null, "Audit security program", new DateTime(2024, 11, 1, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4434), "high", new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4434) },
                    { new Guid("625ce82d-896f-4ac1-a43e-0573ad36411c"), "Diane Basham", "Neil Ranada", null, "Review code", new DateTime(2024, 2, 22, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4034), "low", new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4034) },
                    { new Guid("6a056730-b742-44bd-9758-0907368353cf"), "Neil Ranada", "Neil Ranada", null, "Sign security agreements", new DateTime(2024, 7, 7, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4341), "low", new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4341) },
                    { new Guid("83697a92-a49e-498b-bc72-e07f6f18963d"), "Keisha Weiland", "Tammy Wescott", null, "Complete cybersecurity training", new DateTime(2024, 11, 28, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4137), "medium", new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4137) },
                    { new Guid("9189defa-bb7e-47ca-96e1-f41ca1948bd6"), "Keisha Weiland", "Billy Dietz", null, "Fix security vulnerability", new DateTime(2025, 1, 4, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(3972), "high", new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(3972) },
                    { new Guid("ad25424d-9d4a-45d6-9dc5-1eceecb0f838"), "Katelyn Pham", "Diane Basham", null, "Sign security agreements", new DateTime(2024, 9, 11, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4089), "high", new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4089) },
                    { new Guid("b49484c4-e1eb-4e13-8005-117d472d9f2e"), "Diane Basham", "Billy Dietz", null, "Review and approve security plan", new DateTime(2025, 2, 25, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4291), "high", new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4291) },
                    { new Guid("ce3c917f-7d3c-41cd-8c1f-8d4593053093"), "Keisha Weiland", "Katelyn Pham", null, "Fix security vulnerability", new DateTime(2024, 12, 13, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(3416), "medium", new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(3416) },
                    { new Guid("ffdc6120-ffb5-47c3-a0c3-e6d8d71db07a"), "Keisha Weiland", "Diane Basham", null, "Sign security agreements", new DateTime(2024, 11, 3, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4388), "high", new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4388) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
